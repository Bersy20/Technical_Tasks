using System.Collections.Generic;
using System.Web.Mvc;
using EmployeeAjaxTask.Models;

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

            for (int i = 0; i < 5; i++)
            {
                if(empDetails.Email==email[i])
                {
                    return Json(new { msg = "success", data = empDetails }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { msg = "invalid" }, JsonRequestBehavior.AllowGet);
        }
    }
}