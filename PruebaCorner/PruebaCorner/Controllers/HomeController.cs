using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaCorner.Controllers
{
    public class HomeController : Controller
    {

        //PruebaAgilEntities db = new PruebaAgilEntities();

        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        /*public ActionResult Prueba()
        {
            List<TipoProyecto> listaTipoProyecto = db.TipoProyecto.ToList();
            ViewBag.listaTipoProyectos = new SelectList(listaTipoProyecto, "id_tipoProyecto", "nombreTipoProyecto");

            return View();
        }*/


    }
}