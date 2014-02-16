using System.Web;
using System.Web.Optimization;

namespace LacysMobile
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Bundles/modernizr").Include(
                        "~/Scripts/modernizr-{version}.js"));
            
            bundles.Add(new ScriptBundle("~/Bundles/Bootstrap").IncludeDirectory("~/Scripts/Bootstrap", "*.js", true));

            bundles.Add(new ScriptBundle("~/Bundles/jquerymobile").Include("~/Scripts/-{version}.jquery.mobile.js"));
            
            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include("~/Content/Bootstrap/less/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/Bootstrap/BootstrapTheme").Include("~/Content/Bootstrap/BootstrapTheme/bootstrapTheme.css"));

            bundles.Add(new StyleBundle("~/Content/Layout").Include("~/Content/Layout/layout.css"));

            bundles.Add(new StyleBundle("~/Content/CSS").Include());
        }
    }
}