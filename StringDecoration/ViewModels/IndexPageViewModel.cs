using StringDecorationContract.ViewModels;
using StringDecorationLib;
using StringDecorationLibContract.Decorators;
using StringDecorationLibContract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StringDecoration.ViewModels
{
    public class IndexPageViewModel : IIndexPageViewModel
    {
        private string inputText;

        /// <summary>
        /// 入力されたテキスト
        /// 変更時にはデコレート処理を行う
        /// </summary>
        public string InputText
        {
            get => inputText;
            set
            {
                inputText = value;
                OnDecorate();
            }
        }

        /// <summary>
        /// デコレートされたテキスト
        /// </summary>
        public string DecoratedText { get; set; }

        /// <summary>
        /// 現在選択されているデコレータの実体
        /// </summary>
        private IStringDecorator Decorator { get; set; }

        
        private DecorateType selectedDecorateType;

        public DecorateType SelectedDecorateType
        {
            get => selectedDecorateType;
            set
            {
                selectedDecorateType = value;
                OnSelectedDecorateTypeUpdated();
            }
        }

        public IEnumerable<DecorateType> SelectableDecorateType { get; set; }

        public IndexPageViewModel()
        {
            Initializie();
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        private void Initializie()
        {
            SelectableDecorateType = Enum.GetValues(typeof(DecorateType))
                                         .Cast<DecorateType>()
                                         .ToArray();

            SelectedDecorateType = DecorateType.None;
        }

        /// <summary>
        /// デコレータの選択が更新された際の処理
        /// </summary>
        private void OnSelectedDecorateTypeUpdated()
        {
            Decorator = StringDecoratorResolver.Resolve(SelectedDecorateType);

            OnDecorate();
        }

        /// <summary>
        /// デコレート処理
        /// </summary>
        private void OnDecorate()
        {
            DecoratedText = Decorator.DecorateAll(InputText);
        }
    }
}
