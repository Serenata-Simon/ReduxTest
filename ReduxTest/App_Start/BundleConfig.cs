using System.Web;
using System.Web.Optimization;
using System.Web.Optimization.React;

namespace ReduxTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new BabelBundle("~/bundles/actions")
                    .IncludeDirectory("~/App/actions", "*.js"));

            bundles.Add(
                new BabelBundle("~/bundles/reducers")
                    .IncludeDirectory("~/App/reducers", "*.js"));

            bundles.Add(
                new BabelBundle("~/bundles/containers")
                    .IncludeDirectory("~/App/containers", "*.js"));

            bundles.Add(
                new BabelBundle("~/bundles/components")
                    .IncludeDirectory("~/App/components", "*.js"));
        }
    }
}
