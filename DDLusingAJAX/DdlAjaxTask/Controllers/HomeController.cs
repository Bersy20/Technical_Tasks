using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DdlAjaxTask.Models;

namespace DdlAjaxTask.Controllers
{
    public class HomeController : Controller
    {
        DdlAjaxEntities ajaxEntities = new DdlAjaxEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCountry()
        {
            List<tbl_Country> CountryList = ajaxEntities.tbl_Country.ToList();
            return Json( CountryList , JsonRequestBehavior.AllowGet);           
        }
        public JsonResult GetState(string Country)
        {
            ajaxEntities.Configuration.ProxyCreationEnabled = false;
            tbl_Country CID = ajaxEntities.tbl_Country.Where(x => x.Country == Country).SingleOrDefault();
            int cid = CID.Id;
            List<tbl_State> StateList = ajaxEntities.tbl_State.Where(x => x.CId ==cid ).ToList();
            return Json(new {msg= "success", data= StateList }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDistrict(string State)
        {

            ajaxEntities.Configuration.ProxyCreationEnabled = false;
            tbl_State SID = ajaxEntities.tbl_State.Where(x => x.State == State).SingleOrDefault();
            int sid = SID.Id;
            List<tbl_District> DistrictList = ajaxEntities.tbl_District.Where(x => x.SId == sid).ToList();
            return Json(new { msg = "success", data = DistrictList }, JsonRequestBehavior.AllowGet);
        }
    }
}