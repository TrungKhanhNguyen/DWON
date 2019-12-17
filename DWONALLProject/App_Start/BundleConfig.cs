using System.Web;
using System.Web.Optimization;

namespace DWONALLProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.js",
                        "~/Scripts/owl.carousel.js",
                        "~/Scripts/default.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/fontawesome.css",
                       "~/Content/owl.carousel.css",
                       "~/Content/owl.theme.default.css",
                      "~/Content/header.css",
                      "~/Content/main.css"
                      //"~/Content/css_003.css",
                      //"~/Content/css_004.css",
                      //"~/Content/css_005.css",
                      //"~/Content/css_006.css",
                      ));
        }
    }
}
