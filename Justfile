#!/usr/bin/env just --justfile

set windows-shell := ["powershell.exe", "-NoLogo", "-Command"]

default:
  just --list

format-csharpier path:
  dotnet csharpier format {{path}}

format-jb path:
  dotnet jb cleanupcode {{justfile_directory()}}/CSharpEditorConfig.slnx --profile="Built-in: Reformat Code"

format path:
  dotnet format

[windows]
[script("powershell.exe")]
remove-bom:
  Get-ChildItem -Path {{justfile_directory()}} -File -Recurse | Where-Object FullName -NotMatch "(\\|/)(bin|obj)(\\|/)" | ForEach-Object {
    $reader = $_.OpenRead()
    $byteBuffer = New-Object System.Byte[] 3
    $bytesRead = $reader.Read($byteBuffer, 0, 3)
    if ($bytesRead -eq 3 -and $byteBuffer[0] -eq 239 -and $byteBuffer[1] -eq 187 -and $byteBuffer[2] -eq 191 -and ! $_.IsReadOnly) {
      Write-Output "Removing UTF8 BOM on $($_.FullName)"
      $tempfile = [System.IO.Path]::GetTempFileName()
      $writer = [System.IO.File]::OpenWrite($tempFile)
      $reader.CopyTo($writer)
      $writer.Dispose()
      $reader.Dispose()
      Move-Item -Path $tempfile -Destination $_.FullName -Force
    }
    else {
      $reader.Dispose()
    }
  }
