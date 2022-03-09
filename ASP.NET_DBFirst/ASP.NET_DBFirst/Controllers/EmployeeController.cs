using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_DBFirst.Models;

namespace ASP.NET_DBFirst.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDBContext dBContext = new EmployeeDBContext();

        public ActionResult EmployeeList()
        {
            return View(dBContext.Employees.ToList());
        }
    }
}