﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Areas.Cms.Controllers
{
    [Area("Cms")]
    public class ReadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}