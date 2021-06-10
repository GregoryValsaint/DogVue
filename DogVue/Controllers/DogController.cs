using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogVue.Controllers
{
    public class DogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
