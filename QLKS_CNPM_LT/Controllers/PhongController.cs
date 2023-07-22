using QLKS_CNPM_LT.Models.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKS_CNPM_LT.Controllers
{
    public class PhongController : Controller
    {
        // GET: Phong
        public ActionResult DSPhong()
        {
            var func_phong = new Phong_Func();
            return View(func_phong.toanBoPhong());
        }
    }
}