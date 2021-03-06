﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Westwind.Web;
using Westwind.Web.Mvc;

namespace WestwindToolkitMvcWeb.Controllers
{
    public class UtilitiesController : Controller
    {
        //
        // GET: /Utilities/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ScriptVariables()
        {
    

            return View();
        }

        public string ViewRenderer()
        {

            var renderer = new ViewRenderer();
            return renderer.RenderView("~/Views/Utilities/ScriptVariables.cshtml", null);

        }

        public string ErrorHandler()
        {
            try
            {
                string x = null;
                x.ToString();
            }
            catch (Exception ex)
            {
                var eh = new WebErrorHandler(ex);
                return eh.ToString();
            }

            return null;
        }

    }
}
