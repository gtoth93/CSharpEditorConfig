#pragma warning disable CA1822
#pragma warning disable CS0067
#pragma warning disable CS0169
#pragma warning disable CS0219
#pragma warning disable CS0414
#pragma warning disable CS8618
#pragma warning disable format
#pragma warning disable IDE0004 // Remove Unnecessary Cast
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0059 // Unnecessary assignment of a value
// ReSharper disable ArrangeStaticMemberQualifier
// ReSharper disable ArrangeThisQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable RedundantCast
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedType.Local

using System;
using System.IO;

namespace CSharpEditorConfig.Style;

public class Rider
{
    // ReSharper restore RedundantNameQualifier

    class SimplifyName
    {
        private System.IO.FileInfo _file;
    }

    // ReSharper disable RedundantNameQualifier

    // ReSharper restore ArrangeStaticMemberQualifier

    class SimplifyMemberAccess
    {
        static void M1() { }

        static void M2()
        {
            SimplifyMemberAccess.M1();
        }
    }

    // ReSharper disable ArrangeStaticMemberQualifier

    // ReSharper restore ArrangeThisQualifier

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

        private void QualificationForEvent()
        {
            this.Elapsed += (_, _) => { };
        }
    }

    // ReSharper disable ArrangeThisQualifier

#pragma warning restore IDE0004 // Remove Unnecessary Cast
    // ReSharper restore RedundantCast

    private void UnnecessaryCast()
    {
        int v = (int)0;
    }

    // ReSharper disable RedundantCast
#pragma warning disable IDE0004 // Remove Unnecessary Cast
}
