#pragma warning disable CA1822
#pragma warning disable CS0067
#pragma warning disable CS0169
#pragma warning disable CS0219
#pragma warning disable CS0414
#pragma warning disable CS8618
#pragma warning disable IDE0001 // Simplify Names
#pragma warning disable IDE0002 // Simplify Member Access
#pragma warning disable IDE0003 // Remove qualification
#pragma warning disable IDE0004 // Remove Unnecessary Cast
#pragma warning disable IDE0005 // Using directive is unnecessary
#pragma warning disable IDE0009 // Member access should be qualified.
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0051 // Remove unused private members
#pragma warning disable IDE0052 // Remove unread private members
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable IDE1006 // Naming Styles

using System;
using System.IO;

namespace CSharpEditorConfig.Style;

public class VisualStudio
{
#pragma warning restore IDE0001 // Simplify name

    class SimplifyName
    {
        private System.IO.FileInfo file;
    }

#pragma warning disable IDE0001 // Simplify name

#pragma warning restore IDE0002 // Simplify Member Access

    class SimplifyMemberAccess
    {
        static void M1() { }

        static void M2()
        {
            SimplifyMemberAccess.M1();
        }
    }

#pragma warning disable IDE0002 // Simplify Member Access

#pragma warning restore IDE0003 // Remove qualification
#pragma warning restore IDE0009 // Member access should be qualified.

    class ThisPreferences
    {
        private int _capacity;

        public int ID { get; set; }

        public event EventHandler Elapsed;

        private void Display() { }

        // dotnet_style_qualification_for_field
        private void QualificationForField()
        {
            this._capacity = 0;
        }

        // dotnet_style_qualification_for_property
        private void QualificationForProperty()
        {
            this.ID = 0;
        }

        // dotnet_style_qualification_for_method
        private void QualificationForMethod()
        {
            this.Display();
        }

        // dotnet_style_qualification_for_event
        private void QualificationForEvent()
        {
            this.Elapsed += (_, _) => { };
        }
    }

#pragma warning disable IDE0003 // Remove qualification
#pragma warning disable IDE0009 // Member access should be qualified.

#pragma warning restore IDE0004 // Remove Unnecessary Cast

    private void UnnecessaryCast()
    {
        int v = (int)0;
    }

#pragma warning disable IDE0004 // Remove Unnecessary Cast
}
