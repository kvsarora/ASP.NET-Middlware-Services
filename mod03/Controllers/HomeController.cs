using Microsoft.AspNetCore.Mvc;
using mod03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mod03.Controllers
{
    public class HomeController : Controller
    {
        private IDataSource dbSource;
        public HomeController(IDataSource dbs)
        {
            dbSource = dbs;
        }
        public IActionResult Index()//action
        {
            var list = dbSource.getRecords();
            return View(list);
        }
    }
}
