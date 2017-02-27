using Abp.Web.Mvc.Views;

namespace MpaAbp.Web.Views
{
    public abstract class MpaAbpWebViewPageBase : MpaAbpWebViewPageBase<dynamic>
    {

    }

    public abstract class MpaAbpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MpaAbpWebViewPageBase()
        {
            LocalizationSourceName = MpaAbpConsts.LocalizationSourceName;
        }
    }
}