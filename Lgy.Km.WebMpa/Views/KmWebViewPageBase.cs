﻿using Abp.Web.Mvc.Views;

namespace Lgy.Km.WebMpa.Views
{
    public abstract class KmWebViewPageBase : KmWebViewPageBase<dynamic>
    {

    }

    public abstract class KmWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected KmWebViewPageBase()
        {
            LocalizationSourceName = KmConsts.LocalizationSourceName;
        }
    }
}