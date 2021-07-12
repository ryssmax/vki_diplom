using System.Web.Optimization;

namespace PM.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts

            bundles.Add(new ScriptBundle("~/bundles/core/js").Include(
                "~/Scripts/bootstrap/bootstrap.js",
                "~/Scripts/jquery/jquery-{version}.js",
                "~/Scripts/jquery.unobtrusive-ajax.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/moment.min.js",
                "~/Scripts/iziToast.js",
                "~/Scripts/site.js"));

            bundles.Add(new ScriptBundle("~/LandPage/core/js").Include(
              "~/Content/Assets/vendors/jquery/jquery.min.js",
              "~/Content/Assets/vendors/imagesloaded/imagesloaded.pkgd.js",
              "~/Content/Assets/vendors/isotope-layout/isotope.pkgd.js",
              "~/Content/Assets/vendors/jquery-one-page/jquery.nav.min.js",
              "~/Content/Assets/vendors/jquery.easing/jquery.easing.min.js",
              "~/Content/Assets/vendors/jquery.matchHeight/jquery.matchHeight.min.js",
              "~/Content/Assets/vendors/magnific-popup/jquery.magnific-popup.min.js",
              "~/Content/Assets/vendors/masonry-layout/masonry.pkgd.js",
              "~/Content/Assets/vendors/swiper/swiper.jquery.js",
              "~/Content/Assets/vendors/menu/menu.js",
              "~/Content/Assets/vendors/typed/typed.min.js",
              "~/Content/Assets/js/main.js"
             ));

            bundles.Add(new ScriptBundle("~/bundles/chart/js").Include(
                "~/Scripts/Chart.js"));

            bundles.Add(new ScriptBundle("~/bundles/task-edit/js").Include(
                "~/Scripts/summernote.js",
                "~/Scripts/datepicker.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datepicker/js").Include(
                "~/Scripts/datepicker.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/ui-slider/js").Include(
                "~/Scripts/noUiSlider/nouislider.min.js"));

            #endregion Scripts

            #region CSS

            bundles.Add(new StyleBundle("~/Content/landing-page/css").Include(
                "~/Content/landing.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/site-style/css").Include(
                "~/Content/site.css",
                "~/Content/iziToast.css"));

            bundles.Add(new StyleBundle("~/Content/task-edit/css").Include(
                "~/Content/datepicker.min.css",
                "~/Content/summernote.css"));

            bundles.Add(new StyleBundle("~/Content/datepicker/css").Include(
                "~/Content/datepicker.min.css"));

            bundles.Add(new StyleBundle("~/Content/ui-slider/css").Include(
                "~/Content/nouislider.min.css"));

            bundles.Add(new StyleBundle("~/Views/LandPage/css").Include(
              "~/Content/Assets/fonts/fontawesome/font-awesome.min.css",
              "~/Content/Assets/fonts/pe-icon/pe-icon.css",
              "~/Content/Assets/vendors/bootstrap/grid.css",
              "~/Content/Assets/vendors/magnific-popup/magnific-popup.min.css",
              "~/Content/Assets/vendors/swiper/swiper.css",
              "~/Content/Assets/css/main.css"
              ));

            #endregion CSS
        }
    }
}