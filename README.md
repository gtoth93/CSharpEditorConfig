# CSharpEditorConfig

A project with the purpose of unifying formatting and code style rules by creating an .editorconfig file containing every
single C# related rule, with documentation explaining their behavior in both Visual Studio and Jetbrains Rider.

## Goals

### 1. Formatting
Formatting here specifically refers to rules that don't change the code in a file, they only add or remove whitespaces.

The goal here is to either set the formatting rules in a way that both Visual Studio and Rider produces the same results,
or if that is not possible, choose one formatter that can be used for both.

Currently, there are three main formatters in C# land:
- Microsoft Visual Studio (and its CLI version dotnet-format)
- Jetbrains ReSharper (it has a Visual Studio plugin version, a CLI version, and its integrated into Rider)
- CSharpier (a CLI tool, it also has plugins for both Visual Studio and Rider)

Every formatting rule in the .editorconfig file should have comments explaining what the rule does, and what the behavior
of the formatters regarding the rule is. CSharpier only has four formatting rules, so for the rest of the rules, its current
behavior is documented instead.

### 2. Code style
Code style rules, as opposed to formatting rules, change the code in a file, specifically code that can be written in
multiple ways, like expression bodies or statement bodies for methods, or using var or explicit type.

The goal here is to go through all the rules that are
compatible with Visual Studio, then pair these rules to the ones that are compatible with Rider. This way, when making a
change to one of the rules, it can be set for both IDEs. The Visual Studio and ReSharper formatters can apply these rules
automatically, CSharpier however is specifically a whitespace formatter, and does not have this capability.

Again, every code style rule in the .editorconfig file should have comments explaining what the rule does, and what the behavior
of the formatters regarding the rule is.

### 3. Code analysis
Code analysis rules are used to detect potential bugs or code smells in the code. The only thing that can be set here is
the severity of the rule. They may also have a quick fix that can be applied automatically by the Visual Studio or ReSharper
formatters.

This is more of a stretch goal, as there are more than a thousand rules to go through, the CSxxxx rules, the CAxxxx rules,
ReSharper's inspections, and some extra rules. Every rule in the .editorconfig file should have a comment explaining what
the rule does, whether there is a quick fix, and if there is, what the behavior of the formatters is.

## Limitations
This .editorconfig file focuses on C# (and maybe a bit of XML), so F# rules, VB rules and other languages are not included.

## Shortcomings of formatters

### Visual Studio/dotnet-format
- max_line_length is not supported, long lines are not wrapped
- Inconsistent rules, some rules are formatting rules when they should be code style rules, and some rules are code style rules when they should be formatting rules.
- No way to share code cleanup profiles in Visual Studio, meaning that everyone has to setup the correct profile manually.
- Using dotnet-format for a single file is slow, even whitespace formatting takes a couple seconds, it should take milliseconds.

### ReSharper/Rider
- Too many rules, hundreds of formatting and code style rules, thousands of code analyzer rules, who is supposed to make sense of all of this?
- Code cleanup profiles can be shared, but only with a DotSettings file, they cannot be shared through an EditorConfig file.
- Using ReSharper as a cli tool for a single file is slow as well.

### CSharpier
- Mostly a whitespace formatter, no code style rules, no code analyzer rules. (one exception is sorting usings)
- Only the most basic rules can be configured.
- Only supports C# and XML, no support for JSON or YAML.
