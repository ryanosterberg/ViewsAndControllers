﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class StringActivityController : Controller
    {
        // GET: StringActivity
       
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "All starts here.");
        }
        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "The length of your string is " + inputString.Length);
        }
    }
}