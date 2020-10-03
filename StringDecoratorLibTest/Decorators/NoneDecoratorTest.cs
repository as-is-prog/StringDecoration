using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringDecorationLib.Decorators;

namespace StringDecoratorLibTest.Decorators
{
    [TestClass]
    public class NoneDecoratorTest
    {
        [TestMethod]
        public void TestDecorateAll()
        {
            var decorator = new NoneDecorator();

            var testStr = "あいうえおかきくけこさしすせそたちつてと";

            var decoratedStr = decorator.DecorateAll(testStr);

            Assert.AreEqual(testStr, decoratedStr);
        }
    }
}
