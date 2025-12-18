// use pragma warning restore to reenable rules
// use ReSharper restore to reenable rules

#pragma warning disable CA1822
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

using System;

namespace CSharpEditorConfig.Formatting;

public class CSharpier
{
    // trim_trailing_whitespace
    // Test this by adding trailing whitespaces after the Console.WriteLine, then trigger formatting
    public void TrailingWhitespace()
    {
        Console.WriteLine("");
    }

    // max_line_length: add enough parameters to go over the character limit, then trigger formatting
    public void MaxLineLength(
        int parameter1,
        int parameter2,
        int parameter3,
        int parameter4,
        int parameter5,
        int parameter6
    )
    {
        Console.WriteLine(
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        );
    }
}

// insert_final_newline: remove new lines after this comment, then trigger formatting
