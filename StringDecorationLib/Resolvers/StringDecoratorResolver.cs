using StringDecorationLib.Decorators;
using StringDecorationLibContract.Decorators;
using StringDecorationLibContract.Enums;
using System.Collections.Generic;
using System.Diagnostics;

namespace StringDecorationLib
{
    public static class StringDecoratorResolver
    {
        private static readonly IDictionary<DecorateType, IStringDecorator> DecoratorDictionary
                           = new Dictionary<DecorateType, IStringDecorator>
                             {
                                 { DecorateType.None, new NoneDecorator() },
                                 { DecorateType.VoicedConsonantMarks, new VoicedConsonantMarksDecorator() },
                             };

        public static IStringDecorator Resolve(DecorateType decorateType)
        {
            var success = DecoratorDictionary.TryGetValue(decorateType, out var decorator);

            if (success) return decorator;

            // このアサートがされる場合はおそらくDecoratorDictionaryへの追記漏れ
            Debug.Assert(false);

            // [異常系]
            // 登録されていないデコレータが指定された場合は
            // 何もしないデコレータを返す
            return DecoratorDictionary.TryGetValue(DecorateType.None, out decorator) 
                ? decorator
                : new NoneDecorator();
        }
    }
}
