// use pragma warning restore to reenable rules
// use ReSharper restore to reenable rules

#pragma warning disable CA1822
#pragma warning disable CS0067
#pragma warning disable CS0219
#pragma warning disable CS8321
#pragma warning disable IDE0028
#pragma warning disable IDE0039
#pragma warning disable IDE0044
#pragma warning disable IDE0059
#pragma warning disable IDE0060
#pragma warning disable IDE0090
#pragma warning disable IDE0300
#pragma warning disable IDE1006
// ReSharper disable ConvertToAutoProperty
// ReSharper disable ConvertToConstant.Local
// ReSharper disable ConvertToLambdaExpression
// ReSharper disable ConvertIfStatementToConditionalTernaryExpression
// ReSharper disable EmptyForStatement
// ReSharper disable EventNeverSubscribedTo.Global
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable RedundantCast
// ReSharper disable RedundantJumpStatement
// ReSharper disable RedundantTypeDeclarationBody
// ReSharper disable SeparateLocalFunctionsWithJumpStatement
// ReSharper disable SwitchStatementHandlesSomeKnownEnumValuesWithDefault
// ReSharper disable UnreachableSwitchCaseDueToIntegerAnalysis
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedVariable
// ReSharper disable UseCollectionExpression

// dotnet_sort_system_directives_first: shuffle usings, then trigger formatting
// dotnet_separate_import_directive_groups: shuffle usings, then trigger formatting
using System;
using System.Collections.Generic;
using System.Linq;
using CSharpEditorConfig.Common;

namespace CSharpEditorConfig.Formatting;

public class VisualStudio
{
    // trim_trailing_whitespace
    // Test this by adding trailing whitespaces after the Console.WriteLine, then trigger formatting
    public void TrailingWhitespace()
    {
        Console.WriteLine("");
    }

    // max_line_length: add enough parameters to go over the character limit, then trigger formatting
    public void MaxLineLength(int parameter1, int parameter2, int parameter3, int parameter4, int parameter5,
        int parameter6)
    {
        Console.WriteLine(
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
    }

    // csharp_new_line_before_else
    public void NewLineBeforeElse()
    {
        int a = Random.Shared.Next();
        if (a > 5)
        {
            Console.WriteLine("if");
        }
        else
        {
            Console.WriteLine("else");
        }
    }

    // csharp_new_line_before_catch
    public void NewLineBeforeCatch()
    {
        try
        {
            Console.WriteLine("try");
        }
        catch
        {
            Console.WriteLine("catch");
        }
    }

    // csharp_new_line_before_finally
    public void NewLineBeforeFinally()
    {
        try
        {
            Console.WriteLine("try");
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }

    // csharp_new_line_before_members_in_object_initializers
    public void NewLineBeforeMembersInObjectInitializers()
    {
        ClassWithTwoMembers a = new ClassWithTwoMembers { A = 1, B = 2 };

        ClassWithFourMembers b = new ClassWithFourMembers { A = 1, B = 2, C = 3 };

        ClassWithSixMembers c = new ClassWithSixMembers
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            F = 6
        };

        ClassWithTwoLongMembers d = new ClassWithTwoLongMembers()
        {
            AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA = 1,
            BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB = 2
        };
    }

    // csharp_new_line_before_members_in_anonymous_types
    public void NewLineBeforeMembersInAnonymousTypes()
    {
        var a = new
        {
            A = 1,
            B = 2
        };

        var b = new
        {
            A = 1,
            B = 2,
            C = 3
        };

        var c = new
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            F = 6
        };

        var d = new
        {
            AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA = 1,
            BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB = 2
        };
    }

    // csharp_new_line_between_query_expression_clauses
    public void NewLineBetweenQueryExpressionClauses()
    {
        List<int> list = [1, 2, 3, 4, 5];
        IEnumerable<int> q1 = from a in list
                              from b in list
                              select a * b;

        IEnumerable<int> q2 = from aaaaaaaaaaaaaaaaaa in list
                              from bbbbbbbbbbbbbbbbbbbb in list
                              select aaaaaaaaaaaaaaaaaa * bbbbbbbbbbbbbbbbbbbb;
    }

    // csharp_indent_case_contents
    public void IndentCaseContents()
    {
        EnumWithThreeMembers e = EnumWithThreeMembers.A;
        switch (e)
        {
            case EnumWithThreeMembers.A:
                Console.WriteLine("A");
                break;
            case EnumWithThreeMembers.B:
                Console.WriteLine("B");
                break;
            default:
                Console.WriteLine("C");
                break;
        }
    }

    // csharp_indent_switch_labels
    public void IndentSwitchLabels()
    {
        EnumWithThreeMembers e = EnumWithThreeMembers.A;
        switch (e)
        {
            case EnumWithThreeMembers.A:
                Console.WriteLine("A");
                break;
            case EnumWithThreeMembers.B:
                Console.WriteLine("B");
                break;
            default:
                Console.WriteLine("C");
                break;
        }
    }

    // csharp_indent_labels
    public void IndentLabels()
    {
        int num = Random.Shared.Next(0, 10);

        if (num > 5)
        {
            goto moreThanFive;
        }

        moreThanFive:
        Console.WriteLine("More than five");
    }

    // csharp_indent_block_contents
    public void IndentBlockContents()
    {
        Console.WriteLine();
    }

    // csharp_indent_braces
    public void IndentBraces()
    {
        Console.WriteLine();
    }

    // csharp_indent_case_contents_when_block
    public void IndentCaseContentsWhenBlock()
    {
        EnumWithThreeMembers e = EnumWithThreeMembers.A;
        switch (e)
        {
            case EnumWithThreeMembers.A:
            {
                Console.WriteLine("A");
                break;
            }
            case EnumWithThreeMembers.B:
            {
                Console.WriteLine("B");
                break;
            }
            default:
            {
                Console.WriteLine("C");
                break;
            }
        }
    }

    // csharp_space_after_cast
    public void SpaceAfterCast()
    {
        int x = 5;
        double y = (double)x;
    }

    // csharp_space_after_keywords_in_control_flow_statements
    public void SpaceAfterKeywordsInControlFlowStatements()
    {
        int a = Random.Shared.Next(0, 10);
        if (a > 5)
        {
            Console.WriteLine("More than five");
        }
    }

    // csharp_space_between_parentheses
    public void SpaceBetweenParentheses()
    {
        int control_flow_statements = Random.Shared.Next(0, 10);
        if (control_flow_statements > 5)
        {
            Console.WriteLine("More than five");
        }

        int x = 4;
        int y = 3;
        int expressions = (x * y) - ((y - x) * 3);

        long type_casts = (long)x;
    }

    // csharp_space_around_binary_operators
    public int SpaceAroundBinaryOperators()
    {
        int x = 5;
        int y = 3;

        return x * (x - y);
    }

    // csharp_space_between_method_declaration_parameter_list_parentheses
    public void SpaceBetweenMethodDeclarationParameterListParentheses(int parameter)
    {
        Console.WriteLine();
    }

    // csharp_space_between_method_declaration_empty_parameter_list_parentheses
    public void SpaceBetweenMethodDeclarationEmptyParameterListParentheses()
    {
        Console.WriteLine();
    }

    // csharp_space_between_method_declaration_name_and_open_parenthesis
    public void SpaceBetweenMethodDeclarationNameAndOpenParenthesis()
    {
        Console.WriteLine();
    }

    // csharp_space_between_method_call_parameter_list_parentheses
    public void SpaceBetweenMethodCallParameterListParentheses()
    {
        Console.WriteLine("param");
    }

    // csharp_space_between_method_call_empty_parameter_list_parentheses
    public void SpaceBetweenMethodCallEmptyParameterListParentheses()
    {
        Console.WriteLine();
    }

    // csharp_space_between_method_call_name_and_opening_parenthesis
    public void SpaceBetweenMethodCallNameAndOpeningParenthesis()
    {
        Console.WriteLine();
    }

    // csharp_space_after_comma
    public void SpaceAfterComma()
    {
        int[] x = [1, 2, 3, 4, 5];
    }

    // csharp_space_before_comma
    public void SpaceBeforeComma()
    {
        int[] x = [1, 2, 3, 4, 5];
    }

    // csharp_space_after_dot
    public void SpaceAfterDot()
    {
        Console.WriteLine();
    }

    // csharp_space_before_dot
    public void SpaceBeforeDot()
    {
        Console.WriteLine();
    }

    // csharp_space_after_semicolon_in_for_statement
    public void SpaceAfterSemicolonInForStatement()
    {
        int[] x = [1, 2, 3, 4, 5];
        for (int i = 0; i < x.Length; i++)
        {
        }
    }

    // csharp_space_before_semicolon_in_for_statement
    public void SpaceBeforeSemicolonInForStatement()
    {
        int[] x = [1, 2, 3, 4, 5];
        for (int i = 0; i < x.Length; i++)
        {
        }
    }

    // csharp_space_around_declaration_statements
    public void SpaceAroundDeclarationStatements()
    {
        int x = 0;
    }

    // csharp_space_before_open_square_brackets
    public void SpaceBeforeOpenSquareBrackets()
    {
        int[] numbers = new[] { 1, 2, 3, 4, 5 };
    }

    // csharp_space_between_empty_square_brackets
    public void SpaceBetweenEmptySquareBrackets()
    {
        int[] numbers = new[] { 1, 2, 3, 4, 5 };
    }

    // csharp_space_between_square_brackets
    public void SpaceBetweenSquareBrackets()
    {
        int[] numbers = [1, 2, 3, 4, 5];
        int number = numbers[0];
    }

    // csharp_preserve_single_line_statements
    public void PreserveSingleLineStatements()
    {
        int i = 0;
        string name = "John";
    }

    // csharp_new_line_before_open_brace
    public class NewLineBeforeOpenBrace
    {
        private int[] arr = new int[100];

        public int Properties
        {
            // accessors
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }

        public event EventHandler EventStore = (sender, args) => { };

        public event EventHandler Events
        {
            // accessors
            add
            {
                EventStore += value;
            }
            remove
            {
                EventStore -= value;
            }
        }

        // indexer
        public int this[int i]
        {
            // accessors
            get
            {
                return arr[i];
            }

            set
            {
                arr[i] = value;
            }
        }

        public void Methods()
        {
            Func<int, int, int> anonymous_methods = delegate (int a, int b)
            {
                return a + b;
            };

            var anonymous_types = new
            {
                a = 1,
                b = 2,
                c = 3,
                d = 4,
                e = 5
            };

            if (anonymous_types.a > 0)
            {
                Console.WriteLine(
                    "control_blocks: if, else if, else, for, foreach, while, do while, try, catch, finally, checked, unchecked, fixed, lock, using");
            }

            Types object_collection_array_initializers = new Types
            {
                A = 1,
                B = 2,
                C = 3,
                D = 4,
                E = 5
            };

            List<int> object_collection_array_initializers2 = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16
            };

            string[] object_collection_array_initializers3 = new[]
            {
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "bbbbbbbbbbbbbbbbbb",
                "ccccccccccccccccccccccccccccccccccc"
            };

            Action lambdas = () =>
            {
                Console.WriteLine("lambdas");
            };

            static void local_functions()
            {
                Console.WriteLine("local_functions");
            }
        }

        public class Types
        {
            public int A { get; set; }
            public int B { get; set; }
            public int C { get; set; }
            public int D { get; set; }
            public int E { get; set; }
        }
    }

    // csharp_space_before_colon_in_inheritance_clause
    public class SpaceBeforeColonInInheritanceClause : ISomeInterface
    {
    }

    // csharp_space_after_colon_in_inheritance_clause
    public class SpaceAfterColonInInheritanceClause : ISomeInterface
    {
    }

    // csharp_preserve_single_line_blocks
    public class PreserveSingleLineBlocks
    {
        public int A { get; set; }
    }

    // resharper_blank_lines_around_region
    public abstract class BlankLinesAroundRegion
    {
        protected abstract void Method1();

        #region Region Description

        protected abstract void Method2();

        #endregion

        protected abstract void Method3();
    }

    // resharper_blank_lines_inside_region
    public abstract class BlankLinesInsideRegion
    {
        protected abstract void Method1();

        #region Region Description

        protected abstract void Method2();

        #endregion

        protected abstract void Method3();
    }

    // resharper_blank_lines_before_single_line_comment
    public void BlankLinesBeforeSingleLineComment()
    {
        var x = 5;
        // comment
        Console.WriteLine();
        ////CommentedCall();
    }
}

// insert_final_newline: remove new lines after this comment, then trigger formatting
