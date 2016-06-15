using System.Web.Optimization;

namespace adRom.WebhookListener
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css"
            ));
        }
    }
}