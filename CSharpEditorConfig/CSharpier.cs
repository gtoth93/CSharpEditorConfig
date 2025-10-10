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
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

using System;
using System.Collections.Generic;
using System.Linq;
using FormatterTest.Common;
using NodaTime;

namespace CSharpEditorConfig;

public class CSharpier
{
    public void SomeMethod1(
        int param1,
        int param2,
        int param3,
        int param4,
        int param5,
        int param6,
        int param7,
        int param8,
        int param9
    )
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

        var obj1 = new SomeObject
        {
            SomeProperty1 = 3,
            SomeProperty2 = 4,
            SomeProperty3 = 5,
            SomeProperty4 = 6,
            SomeProperty5 = 7,
            SomeProperty6 = 8,
            SomeProperty7 = 9,
        };

        var obj2 = new SomeObject
        {
            SomeProperty1 = 3,
            SomeProperty2 = 4,
            SomeProperty3 = 5,
            SomeProperty4 = 6,
            SomeProperty5 = 7,
            SomeProperty6 = 8,
            SomeProperty7 = 9,
        };

        List<int> list = [1, 2, 3, 4, 5];

        var query1 =
            from a in list
            from b in list
            from c in list
            from d in list
            from e in list
            from f in list
            from g in list
            select a * b * c * d * e * f * g;

        var query2 =
            from a in list
            from b in list
            from c in list
            from d in list
            from e in list
            from f in list
            from g in list
            select a * b * c * d * e * f * g;

        var obj3 = new
        {
            SomeProperty1 = 3,
            SomeProperty2 = 4,
            SomeProperty3 = 5,
            SomeProperty4 = 6,
            SomeProperty5 = 7,
            SomeProperty6 = 8,
            SomeProperty7 = 9,
        };

        var obj4 = new
        {
            SomeProperty1 = 3,
            SomeProperty2 = 4,
            SomeProperty3 = 5,
            SomeProperty4 = 6,
            SomeProperty5 = 7,
            SomeProperty6 = 8,
            SomeProperty7 = 9,
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

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        var z = (integer1 * integer2) - ((integer2 - integer1) * 3);

        int[] numbers = [1, 2, 3, 4, 5];
        int index = numbers[0];

        var now = SystemClock.Instance.GetCurrentInstant();
    }

    private void SomeMethod2()
    {
        var boolean2 = true;

        if (boolean2 == true)
        {
            goto error;
        }

        error:
        throw new Exception();
    }

    class SomeObject2 : ISomeInterface
    {
        public int SomeProperty1 { get; set; }
    }
}
