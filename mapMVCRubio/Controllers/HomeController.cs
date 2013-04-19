using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace mapMVCRubio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Proyecto Diseno de Sistemas Operativos";

            return View();
        }
                [Authorize]
        public ActionResult about()
        {

            ViewBag.Message = "Somos unos jovenes emprendedores que tratan de aplicar sus conocimientos para el beneficio del pais";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pide tu taxi ahora!!!!";

            return View();
        }



        public ActionResult MiMapa()
        {
            ViewBag.Latitud = System.Web.HttpContext.Current.Application["latitud"];
            ViewBag.Longitud = System.Web.HttpContext.Current.Application["longitud"];
            return View();
        }

        public ActionResult Admin(string latitud, string longitud , string estado)
        {
            if (!(String.IsNullOrEmpty(latitud) && String.IsNullOrEmpty(longitud)))
            {
                System.Web.HttpContext.Current.Application["latitud"] = latitud;
                System.Web.HttpContext.Current.Application["longitud"] = longitud;
            }
            if (!(String.IsNullOrEmpty(estado)))
            {
                System.Web.HttpContext.Current.Application["estado"] = estado;
            }


            ViewBag.Latitud = System.Web.HttpContext.Current.Application["latitud"];
            ViewBag.Longitud = System.Web.HttpContext.Current.Application["longitud"];
            ViewBag.Estado = System.Web.HttpContext.Current.Application["estado"];
            return View();
        }
    }
}
