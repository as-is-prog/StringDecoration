using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringDecorationLib;
using StringDecorationLib.Decorators;
using StringDecorationLibContract.Enums;
using System;
using System.Linq;

namespace StringDecoratorLibTest.Resolvers
{
    [TestClass]
    public class StringDecoratorResolverTest
    {
        /// <summary>
        /// Noneを除くすべてのDecorateTypeに対応するDecoratorが定義されていることをテストします
        /// </summary>
        [TestMethod]
        public void TestResolve()
        {
            var noneDecoratorExist = Enum.GetValues(typeof(DecorateType))
                                         .Cast<DecorateType>()
                                         .Where(dt => dt != DecorateType.None)
                                         .Select(dt => StringDecoratorResolver.Resolve(dt))
                                         .Any(decorator => decorator is NoneDecorator);

            // NoneDecoratorは異常値のため、返ってこないことを期待
            Assert.IsFalse(noneDecoratorExist);
        }
    }
}
