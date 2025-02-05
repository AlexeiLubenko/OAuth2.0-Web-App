﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

namespace Authenticate.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View("Index", User);
        }

        [Route("/"), Route("Main")]
        public IActionResult Main()
        {
            return View("Main");
        }

        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }
        
    }
}
