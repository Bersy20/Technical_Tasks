using EmployeeAjaxTask.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EmployeeAjaxTask.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult EmployeeDetails(EmpDetails empDetails)
        {
            List<string> email = new List<string>();
            email.Add("bersy@gmail.com");
            email.Add("gemsy@gmail.com");
            email.Add("arun@gmail.com");
            email.Add("tharun@gmail.com");
            email.Add("varun@gmail.com");

            var IsExists = email.Contains(empDetails.Email);
            if (IsExists)
            {
                return Json(new { msg = "success", data = empDetails }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { msg = "invalid" }, JsonRequestBehavior.AllowGet);
        }
    }
}