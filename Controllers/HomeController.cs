using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AS_DojoSurveyValidation.Models;

namespace AS_DojoSurveyValidation.Controllers
{
    public class HomeController : Controller
    {
        

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("success")]
        public IActionResult Success(User user)
        {
            return View("Success", user);
        }

        [HttpPost("submit")]
        public IActionResult Submit(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", user);
            }
            else
            {
                return View("index");
            }
        }

    
    }
}
