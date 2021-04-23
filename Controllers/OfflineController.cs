using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskList.Controllers
{
    public class OfflineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
