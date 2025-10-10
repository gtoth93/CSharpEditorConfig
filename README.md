# CSharpEditorConfig

A small project aimed at creating an .editorconfig file containing every single C# related setting with comments explaining
what each setting does and which Visual Studio/dotnet-format setting corresponds to which ReSharper/Rider setting.

The .editorconfig file is structured like this (subject to change):
- Universal settings (these can be used for all file types, not just C#)
  - Settings used by CSharpier
- Settings used by Visual Studio and dotnet-format (some of these settings are also used by ReSharper and Rider, in
each section these settings are grouped under a Common subsection):
  - Formatting settings (dotnet format whitespace)
    - IDE0055: this is the analyzer rule for inconsistent formatting
  - Code Style settings (dotnet format style)
    - IDExxxx analyzer rules and associated options
    - Naming style rules
      - IDE1006: this is the analyzer rule for inconsistent naming
  - Code Analyzer settings (dotnet format analyzers)
    - CAxxxx analyzer rules
    - CSxxxx analyzer rules (compiler warnings and errors)
    - all other analyzer rule sets
- Settings used by ReSharper and Rider

Each setting has a comment next to it explaining what the setting does, or, in the case of ReSharper/Rider settings,
the name of the dotnet-format setting that does the same. The possible values are also added to the comment in round brackets
if it's not a trivial true/false setting.

The project also includes some files for testing changes in the .editorconfig.
