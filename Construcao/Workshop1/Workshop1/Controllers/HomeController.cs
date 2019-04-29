﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

/*
Serve para tratar das vistas (interfaces)
Pasta nas views com o mesmo nome deste controller
    */

namespace Workshop1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            return View("xpto");
        }
    }
}
