using PruebaCorner.Models;
using PruebaCorner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaCorner.Controllers
{
    public class AgilesController : Controller
    {



        //cambiar lo de base de datos nada mas y probar



        //public PruebaAgilEntities db = new PruebaAgilEntities();
        // GET: Agiles
        public ActionResult Index()
        {
            TipoProyectoServices tipoProyectoServices = new TipoProyectoServices();
            ModeloGeneralModels modelo = new ModeloGeneralModels();
            //List<TipoProyecto> listaTipoProyecto = db.TipoProyecto.ToList();
            List<TipoProyectoModels> listaTipoProyecto = tipoProyectoServices.ObtenerListadoTiposProyectos();
            modelo.listaTipos = new SelectList(listaTipoProyecto, "id_tipoProyecto", "nombreTipoProyecto");

            TareasXTipoProyectoServices task = new TareasXTipoProyectoServices();
            var lista1 = task.listadoTareasXUnTipoProyecto(1).listaTareasEnEsteTipoProyecto;
            ViewBag.algo = lista1;

            //var num = lista.id_tipoProyecto;

            //ViewBag.ListaTTPUNO = task.listadoTareasXUnTipoProyecto(1);*/


            return View(modelo);
        }

        [HttpPost]
        public ActionResult Index(int id_tipo)
        {
            //aca esta el problema
            //var lista = db.TareasXTipoProyecto.Where(d => d.id_tipoProyecto == Convert.ToInt32(listaTipos.ToList()));
            ModeloGeneralModels modelo = new ModeloGeneralModels();
            TipoProyectoServices tipoProyectoServices = new TipoProyectoServices();
            TareasXTipoProyectoServices TTPS = new TareasXTipoProyectoServices();
            
            
            List<TipoProyectoModels> listaTipoProyecto = tipoProyectoServices.ObtenerListadoTiposProyectos();
            modelo.listaTipos = new SelectList(listaTipoProyecto, "id_tipoProyecto", "nombreTipoProyecto");

            var lista = TTPS.listadoTareasXUnTipoProyecto(id_tipo);
            //lista.
            /*foreach (TareaModels tar in lista.listaTareasEnEsteTipoProyecto)
            {
                TareaModels tarea = new TareaModels();
                tarea.id_tarea = tar.id_tarea;
                tarea.nombreTarea = tar.nombreTarea;
                modelo.listaTareas.Add(tarea);
            }//faltan los otros atributos y que traiga el nombre no el id*/

            modelo.listaPreOrden = lista.listaNumPreOrdenEnEsteTipoProyecto;
            modelo.listaTareas = lista.listaTareasEnEsteTipoProyecto;


            var lista1 = TTPS.listadoTareasXUnTipoProyecto(3).listaTareasEnEsteTipoProyecto;
            ViewBag.algo = lista1;

            return View(modelo);
        }


        /*public ViewResult Grid()
        {
            ModeloGeneralModels modelo = new ModeloGeneralModels();
            TipoProyectoServices tipoProyectoServices = new TipoProyectoServices();
            TareasXTipoProyectoServices TTPS = new TareasXTipoProyectoServices();
            var lista = TTPS.listadoTareasXUnTipoProyecto(3);
            modelo.listaTareas = lista.listaTareasEnEsteTipoProyecto;

            return View(modelo);
        }*/
        

    }
}


