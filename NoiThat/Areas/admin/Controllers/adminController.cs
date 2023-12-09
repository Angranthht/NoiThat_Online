using NoiThat.Controllers;
using NoiThat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NoiThat.Areas.admin.Controllers
{
    public class adminController : Controller
    {
        public dbNoiThatOnlineDataContext data;

        public adminController()
        {
            data = Connect.GetConnect();
        }

        public ActionResult Index()
        {
            if (Session["admin"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "loginAdmin");
            }
        }
    }
}