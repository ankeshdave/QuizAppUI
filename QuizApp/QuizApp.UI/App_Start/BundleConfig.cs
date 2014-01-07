﻿using System.Web;
using System.Web.Optimization;

namespace QuizApp.UI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Remove the file ignore list as it might remove '.min.*' files from bundling
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/assets/js/iecompatibility").Include(
                "~/assets/js/html5shiv.js",
                "~/assets/js/respond.min.js"));


            bundles.Add(new ScriptBundle("~/mainscripts").Include(
                "~/assets/js/bootstrap.min.js",
                "~/assets/js/typeahead-bs2.min.js",
                "~/assets/js/ace-elements.min.js",
                "~/assets/js/ace.min.js"));

            bundles.Add(new StyleBundle("~/assets/css").Include(
                "~/assets/css/bootstrap.min.css",
                "~/assets/css/font-awesome.min.css",
                "~/assets/css/ace.min.css",
                "~/assets/css/ace-rtl.min.css",
                "~/assets/css/ace-skins.min.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                "~/Content/themes/base/jquery.ui.core.css",
                "~/Content/themes/base/jquery.ui.resizable.css",
                "~/Content/themes/base/jquery.ui.selectable.css",
                "~/Content/themes/base/jquery.ui.accordion.css",
                "~/Content/themes/base/jquery.ui.autocomplete.css",
                "~/Content/themes/base/jquery.ui.button.css",
                "~/Content/themes/base/jquery.ui.dialog.css",
                "~/Content/themes/base/jquery.ui.slider.css",
                "~/Content/themes/base/jquery.ui.tabs.css",
                "~/Content/themes/base/jquery.ui.datepicker.css",
                "~/Content/themes/base/jquery.ui.progressbar.css",
                "~/Content/themes/base/jquery.ui.theme.css"));

        }
    }
}