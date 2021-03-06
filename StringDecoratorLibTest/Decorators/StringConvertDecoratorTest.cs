using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringDecorationLib.Decorators;

namespace StringDecoratorLibTest.Decorators
{
    [TestClass]
    public class StringConvertDecoratorTest
    {
        [DataTestMethod]
        [DataRow("", "")]
        [DataRow(" ", " ")]
        [DataRow("0120-828-828", "０１２０ー８２８ー８２８")]
        [DataRow("TESTABC", "ＴＥＳＴＡＢＣ")]
        [DataRow("testabc", "ｔｅｓｔａｂｃ")]
        [DataRow("ﾃｽﾄｲﾛﾊ", "テストイロハ")]
        [DataRow("!?/@~_:;{}", "！？／＠〜＿：；｛｝")]
        public void TestDecorateAll(string input, string expectedOutput)
        {
            var decorator = new HalfWidthToFullWidthDecorator();

            var decoratedStr = decorator.DecorateAll(input);

            Assert.AreEqual(expectedOutput, decoratedStr);
        }
    }
}
