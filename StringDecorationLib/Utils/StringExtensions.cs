using System.Collections.Generic;

namespace StringDecorationLib.Utils
{
    /// <summary>
    /// stringクラスに対する拡張メソッド群
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        /// string.Joinをメソッドチェーンで呼び出せるようにしたもの
        /// </summary>
        /// <param name="str"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string JoinString(this IEnumerable<string> str, string separator = "")
        {
            return string.Join(separator, str);
        }
    }
}
