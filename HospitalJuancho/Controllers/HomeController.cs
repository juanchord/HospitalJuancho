﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalJuancho.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Procesos()
        {

            return View();
        }

        public ActionResult Mantenimiento()
        {

            return View();
        }
    }
}