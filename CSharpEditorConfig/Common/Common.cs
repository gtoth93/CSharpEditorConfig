namespace CSharpEditorConfig.Common
{
    public class ClassWithTwoMembers
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    public class ClassWithFourMembers
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
    }

    public class ClassWithSixMembers
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
    }

    public class ClassWithTwoLongMembers
    {
        public int AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA { get; set; }
        public int BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB { get; set; }
    }

    public enum EnumWithThreeMembers
    {
        A,
        B,
        C
    }

    public interface ISomeInterface
    {
    }
}
