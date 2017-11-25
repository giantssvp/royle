﻿using System.Web;
using System.Web.Optimization;

namespace royle
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.4.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/SmoothScroll.min.js",
                      "~/Scripts/move-top.js",
                      "~/Scripts/easing.js",
                      "~/Scripts/responsiveslides.min.js",
                      "~/Scripts/simplePlayer.js",
                      "~/Scripts/waypoints.min.js",
                      "~/Scripts/counterup.min.js",
                      "~/Scripts/jquery.flexslider.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/lightbox.css",
                      "~/Content/style.css",
                      "~/Content/font-awesome.css",
                      "~/Content/flexslider.css"));
        }
    }
}
