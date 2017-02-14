using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult List(string name)
        {
            var input = Server.HtmlEncode(name);
            return  Content(input);
        }
        public String Customers()
        {
            return @"<ul><li>customers</li>
                    <li>Vishal</li>
                    <li>Rahul</li></ul>";
        }
    }
}