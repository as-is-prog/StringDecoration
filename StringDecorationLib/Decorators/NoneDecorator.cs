using StringDecorationLibContract.Decorators;

namespace StringDecorationLib.Decorators
{
    public class NoneDecorator : IStringDecorator
    {
        public string DecorateAll(string allText) => allText;
    }
}
