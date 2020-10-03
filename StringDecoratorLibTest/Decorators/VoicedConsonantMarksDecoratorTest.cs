using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringDecorationLib.Decorators;

namespace StringDecoratorLibTest.Decorators
{
    [TestClass]
    public class VoicedConsonantMarksDecoratorTest
    {
        [DataTestMethod]
        [DataRow("", "")]
        [DataRow(" ", " \"")]
        [DataRow("こふこふ", "こ\"ふ\"こ\"ふ\"")]
        [DataRow("ヴェルフェゴール", "ウ\"ェ\"ル\"フ\"ェ\"コ\"ー\"ル\"")]
        [DataRow("ジグザグ", "シ\"ク\"サ\"ク\"")]
        [DataRow("ちょこせんぱいはー、ごはんをいっぱいたべまーす！", "ち\"ょ\"こ\"せ\"ん\"ぱ\"い\"は\"ー\"、\"こ\"は\"ん\"を\"い\"っ\"ぱ\"い\"た\"へ\"ま\"ー\"す\"！\"")]
        public void TestDecorateAll(string input, string expectedOutput)
        {
            var decorator = new VoicedConsonantMarksDecorator();

            var decoratedStr = decorator.DecorateAll(input);

            Assert.AreEqual(expectedOutput, decoratedStr);
        }
    }
}
