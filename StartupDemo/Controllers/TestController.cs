using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StartupDemo.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("dashboard/tela-inicial")]
        [Route("dashboard/tela-inicial/{id:int}/{valor:guid}")]
        public IActionResult Index()
        {
            //return View();
            //return Json("{'Nome': 'Eduardo'}");
            return RedirectToAction("Test");
        }

        public IActionResult Test()
        {
            return View("Index");
        }
    }
}