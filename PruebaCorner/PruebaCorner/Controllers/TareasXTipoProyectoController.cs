using PruebaCorner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaCorner.Controllers
{
    public class TareasXTipoProyectoController : Controller
    {
        // GET: TareasXTipoProyecto

        public PruebaAgilEntities db = new PruebaAgilEntities();

        public ActionResult Index()
        {
            List<TipoProyecto> listaTipoProyecto = db.TipoProyecto.ToList();
            ViewBag.listaTipoProyectos = new SelectList(listaTipoProyecto, "id_tipoProyecto", "nombreTipoProyecto");

            return View();
         
        }

        /*public ActionResult filtro(int id_tipoProyecto)
        {
            List<Tareas> listaTareas = new List<Tareas>();
            List<Int32> listaPreOrden = new List<int>();
            List<TareasXTipoProyecto> listaTTP = db.TareasXTipoProyecto.ToList();

            foreach (TareasXTipoProyecto TTP in listaTTP)
            {
                if(TTP.id_tipoProyecto==id_tipoProyecto)
                {
                    Tareas tarea = new Tareas();
                    tarea.id_tarea = TTP.id_tarea;
                    listaTareas.Add(tarea);
                    listaPreOrden.Add(TTP.numPreOrden);
                }
            }
            ViewBag.listaTablaTareas = listaTareas;
            ViewBag.listaTablaPreOrden = listaPreOrden;

            return View();
        }*/

        public ActionResult TareasXTipo(int id_tipoProyecto)
        {
            var listaTareas = db.TareasXTipoProyecto.Where(d => d.id_tipoProyecto == id_tipoProyecto).ToList();
            ViewBag.listaTodasTareas = listaTareas;

            return View(listaTareas.ToList());
        }
    }
        
}