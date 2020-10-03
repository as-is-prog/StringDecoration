using StringDecorationLibContract.Enums;
using System.Collections.Generic;

namespace StringDecorationContract.ViewModels
{
    public interface IIndexPageViewModel
    {
        /// <summary>
        /// 入力されたテキスト
        /// </summary>
        string InputText { get; set; }
        /// <summary>
        /// デコレートされたテキスト
        /// </summary>
        string DecoratedText { get; }

        /// <summary>
        /// 選択可能なデコレーターの種類
        /// </summary>
        IEnumerable<DecorateType> SelectableDecorateType { get; }
        /// <summary>
        /// 選択されているデコレーターの種類
        /// </summary>
        DecorateType SelectedDecorateType { get; set; }
    }
}
