using MVCFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var employees = from e in GetEmployeeList()
                            orderby e.id
                            select e;
            return View(employees);
        }
        public List<Home> GetEmployeeList()
        {
            return new List<Home>{
      new Home{
         id = 1,
         Name = "Allan",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 23
      },

      new Home{
         id = 2,
         Name = "Carson",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 45
      },

      new Home{
         id = 3,
         Name = "Carson",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 37
      },

      new Home{
         id = 4,
         Name = "Laura",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 26
      },
   };
        }


        public ActionResult Edit(int id)
        {
            List<Home> empList = GetEmployeeList();
            var employee = empList.Single(m => m.id == id);
            return View(employee);
        }

        
    }
}