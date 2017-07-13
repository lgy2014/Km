using System.Collections.Generic;
using Abp.Localization;

namespace Lgy.Km.WebMpa.Models.Layout
{
    public class LanguageSelectionViewModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public IReadOnlyList<LanguageInfo> Languages { get; set; }
    }
}