﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebIDE.Controllers {
    public class IDEController : Controller {
        public ActionResult Index() {
            return View();
        }
    }
}
