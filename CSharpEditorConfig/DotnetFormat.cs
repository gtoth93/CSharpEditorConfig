// ReSharper disable ConditionIsAlwaysTrueOrFalse
// ReSharper disable NotAccessedField.Local
// ReSharper disable RedundantBoolCompare
// ReSharper disable RedundantCast
// ReSharper disable RedundantDefaultMemberInitializer
// ReSharper disable RedundantJumpStatement
// ReSharper disable UnreachableSwitchCaseDueToIntegerAnalysis
// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedType.Local
// ReSharper disable UnusedVariable
// ReSharper disable UselessBinaryOperation

#pragma warning disable CS0067 // Event is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0414 // Field is assigned but its value is never used
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using FormatterTest.Common;
using NodaTime;

namespace CSharpEditorConfig;

public class DotnetFormat
{
    public static void SomeMethod1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
    {
        var boolean1 = true;

        if (boolean1 == true)
        {
            Console.WriteLine("true");
        }
        else if (boolean1 == false)
        {
            Console.WriteLine("else if");
        }
        else
        {
            Console.WriteLine("false");
        }

        try
        {
            Console.WriteLine("try");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("finally");
        }

        var obj1 = new SomeObject { SomeProperty1 = 3, SomeProperty2 = 4, SomeProperty3 = 5, SomeProperty4 = 6, SomeProperty5 = 7, SomeProperty6 = 8, SomeProperty7 = 9 };

        var obj2 = new SomeObject
        {
            SomeProperty1 = 3,
            SomeProperty2 = 4,
            SomeProperty3 = 5,
            SomeProperty4 = 6,
            SomeProperty5 = 7,
            SomeProperty6 = 8,
            SomeProperty7 = 9
        };

        List<int> list = [1, 2, 3, 4, 5];

        var query1 = from a in list from b in list from c in list from d in list from e in list from f in list from g in list select a * b * c * d * e * f * g;

        var query2 = from a in list
                     from b in list
                     from c in list
                     from d in list
                     from e in list
                     from f in list
                     from g in list
                     select a * b * c * d * e * f * g;

        var obj3 = new { SomeProperty1 = 3, SomeProperty2 = 4, SomeProperty3 = 5, SomeProperty4 = 6, SomeProperty5 = 7, SomeProperty6 = 8, SomeProperty7 = 9 };

        var obj4 = new
        {
            SomeProperty1 = 3,
            SomeProperty2 = 4,
            SomeProperty3 = 5,
            SomeProperty4 = 6,
            SomeProperty5 = 7,
            SomeProperty6 = 8,
            SomeProperty7 = 9
        };

        var color = Color.Red;

        switch (color)
        {
            case Color.Red:
                Console.WriteLine("red");
                break;
            case Color.Blue:
            {
                Console.WriteLine("blue");
                break;
            }
            default:
                Console.WriteLine("default");
                break;
        }

        var integer1 = 5;
        var integer2 = (int)integer1;

        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        var z = (integer1 * integer2) - ((integer2 - integer1) * 3);

        int[] numbers = [1, 2, 3, 4, 5];
        var index = numbers[0];

        var now = SystemClock.Instance.GetCurrentInstant();

        var obj5 = new SomeObject2();

        var enumerable = new List<int>() { 1, 2, 3, 4, 5 };

        var someBytes = "ABC"u8;

        var binop1 = 12 - (3 % 4 * 12);
        var binop2 = ((9 >> (12 + binop1 - 1)) << (2 + 1)) & (6 + (4 * 12) - 1);
        var binop3 = ((2 | 7) + 1) & binop2;

        var binop4 = 12 - (3 % 4 * 12);
        var binop5 = ((9 >> (12 + binop4 - 1)) << (2 + 1)) & (6 + (4 * 12) - 1);
        var binop6 = ((2 | 7) + 1) & binop5;
        var binop7 = (binop1 > 5 && binop2 < 6) || binop3 == 7;
        var binop8 = (binop1 > 6) != (binop2 > 6) && binop1 != null == (binop2 != null);

        var intMax = int.MaxValue;

        using var client = new HttpClient();

        static int Selector(int i) => i * 2;

        var enumerable2 = enumerable.Select(Selector);

        var obj6 = new SomeObject
        {
            SomeProperty1 = 3
        };

        if (int.TryParse("3", out var integer3))
        {
            Console.WriteLine(integer3);
        }

        var someList = new List<int>
        {
            3,
            4
        };

        string? string1 = null;
        var string2 = "";

        var resultString = string1 ?? string2;

        (var name, var age) = SomeMethod4();
        var string3 = name;

        var string4 = name;
        var integer4 = age;
        var tuple2 = (integer4, string4);
        var obj7 = new { integer4, string4 };

        static void SomeFunc(string message)
        {
            Console.WriteLine($"{message}asd");
        }
        SomeFunc(resultString);

        string? string5 = null;

        if (string5 == null)
        {
            Console.WriteLine("string5 is null");
        }

        var (str, integer) = SomeMethod6();
        Console.WriteLine($"{str}, {integer}");



        var helloStr = integer > 5 ? "hello" : "world";
    }

    private static void SomeMethod2()
    {
        var boolean2 = true;

        if (boolean2 == true)
        {
            goto error;
        }

        error:
        throw new Exception();
    }

    private static void SomeMethod3(object? obj)
    {
        _ = obj?.ToString();
    }

    private static (string, int) SomeMethod4()
    {
        return ("abc", 3);
    }

    private static void SomeMethod5(string? str = default) { }

    private static (string str, int integer) SomeMethod6()
    {
        return ("abc", 3);
    }

    private class SomeObject2 : ISomeInterface
    {
        private int _someField1 = 0;

        public int SomeProperty1 { get; set; } = 0;
        public delegate void SomeEventHandler();
        public event SomeEventHandler SomeEvent;
        private readonly Lock _gate = new();
        private string _someString = "";

        public static void SomeMethod1()
        {
            Console.WriteLine("SomeMethod1");
        }

        public SomeObject2()
        {
            SomeEvent += () => { Console.WriteLine("SomeEvent"); };
        }

        public void SomeOtherMethod2()
        {
            _someField1 = 2;
            SomeProperty1 = 3;
            SomeMethod1();
            lock (_gate)
            {

            }
            string someString = null;
            _someString = someString ?? throw new ArgumentNullException(nameof(someString));
        }
    }

    private interface ISomeInterface2
    {
        void SomeMethod1();
    }
}
