﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueJsProject.Controllers
{
    //https://www.cnblogs.com/ywsoftware/p/10948706.html
    public class VueController : Controller
    {
        // GET: Vue
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}