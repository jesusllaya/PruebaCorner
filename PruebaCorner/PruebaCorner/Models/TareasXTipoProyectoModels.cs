using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaCorner.Models
{
    public class TareasXTipoProyectoModels
    {

        /*public List<SelectListItem> opcionesdeTipoProyecto { get; set; }
        public List<TipoProyecto> ListaTipoProyecto { get; set; }
        public List<Tareas> ListaTareas { get; set; }
        public List<Int32> ListaPreOrdenTarea { get; set; }*/

        public int id_tipoProyecto { get; set; }
        //public int id_tarea { get; set; }
        //public int nroPreOrden { get; set; }

        public List<TareaModels> listaTareasEnEsteTipoProyecto { get; set; }
        public List<Int32> listaNumPreOrdenEnEsteTipoProyecto { get; set; }

    }
}