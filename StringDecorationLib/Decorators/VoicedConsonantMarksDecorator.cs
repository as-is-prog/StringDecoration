using StringDecorationLib.Utils;
using StringDecorationLibContract.Decorators;
using System.Collections.Generic;
using System.Linq;

namespace StringDecorationLib.Decorators
{
    /// <summary>
    /// 濁点をつけるデコレータ
    /// </summary>
    internal class VoicedConsonantMarksDecorator : IStringDecorator
    {
        #region 定数
        /// <summary>
        /// 濁点をつける前に置換する文字のディクショナリ
        /// </summary>
        private static IDictionary<char, char> ReplaceCharDictionary = new Dictionary<char, char>
        {
            { 'が', 'か'},
            { 'ぎ', 'き'},
            { 'ぐ', 'く'},
            { 'げ', 'け'},
            { 'ご', 'こ'},

            { 'ざ', 'さ'},
            { 'じ', 'し'},
            { 'ず', 'す'},
            { 'ぜ', 'せ'},
            { 'ぞ', 'そ'},

            { 'だ', 'た'},
            { 'ぢ', 'ち'},
            { 'づ', 'つ'},
            { 'で', 'て'},
            { 'ど', 'と'},

            { 'ば', 'は'},
            { 'び', 'ひ'},
            { 'ぶ', 'ふ'},
            { 'べ', 'へ'},
            { 'ぼ', 'ほ'},

            { 'ガ', 'カ'},
            { 'ギ', 'キ'},
            { 'グ', 'ク'},
            { 'ゲ', 'ケ'},
            { 'ゴ', 'コ'},

            { 'ザ', 'サ'},
            { 'ジ', 'シ'},
            { 'ズ', 'ス'},
            { 'ゼ', 'セ'},
            { 'ゾ', 'ソ'},

            { 'ダ', 'タ'},
            { 'ヂ', 'チ'},
            { 'ヅ', 'ツ'},
            { 'デ', 'テ'},
            { 'ド', 'ト'},

            { 'バ', 'ハ'},
            { 'ビ', 'ヒ'},
            { 'ブ', 'フ'},
            { 'ベ', 'ヘ'},
            { 'ボ', 'ホ'},

            { 'ヴ', 'ウ' }
        };
        #endregion

        public string DecorateAll(string allText)
        {
            return allText?.Select(c => DecirateSingle(c))
                           .JoinString();
        }

        private static string DecirateSingle(char singleChar)
        {
            var c = ReplaceCharDictionary.TryGetValue(singleChar, out var replaced)
                ? replaced
                : singleChar;

            return $"{c}\"";
        }
    }
}
