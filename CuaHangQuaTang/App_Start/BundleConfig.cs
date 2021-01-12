using System.Web;
using System.Web.Optimization;

namespace CuaHangQuaTang
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/js").Include(
                      "~/assets/js/jquery-3.5.1.min.js",
                      "~/assets/js/count-up.min.js",
                      "~/assets/js/main.js",
                      "~/assets/js/wow.min.js",
                      "~/assets/js/app.js",
                      "~/assets/js/notify.min.js",
                      "~/assets/js/bootstrap.bundle-5.0.0.alpha-min.js"));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/assets/css/animate.css",
                      "~/assets/css/LineIcons.2.0.css",
                      "~/assets/css/bootstrap-5.0.5-alpha.min.css",
                      "~/assets/css/style.css"));
        }
    }
}
