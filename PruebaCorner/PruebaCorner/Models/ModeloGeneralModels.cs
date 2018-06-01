using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaCorner.Models;

namespace PruebaCorner.Models
{
    public class ModeloGeneralModels
    {
        public SelectList listaTipos { get; set; }

        public List<TareaModels> listaTareas { get; set; }

        public List<Int32> listaPreOrden { get; set; }
    }
}