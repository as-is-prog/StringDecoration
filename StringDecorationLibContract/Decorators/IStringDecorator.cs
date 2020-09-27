namespace StringDecorationLibContract.Decorators
{
    /// <summary>
    /// 文字に修飾を加える処理のインターフェース
    /// </summary>
    public interface IStringDecorator
    {
        /// <summary>
        /// 任意の1文字に対して修飾を加える処理
        /// </summary>
        /// <param name="singleChar"></param>
        /// <returns></returns>
        string DecorateSingle(string singleChar);

        /// <summary>
        /// 文章全体に対して修飾を加える処理
        /// </summary>
        /// <param name="allText"></param>
        /// <returns></returns>
        string DecorateAll(string allText);
    }
}
