using PruebaCorner.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PruebaCorner.Services
{
    public class TareasServices
    {
        public List<TareaModels> ObtenerListadoTareas()
        {
            List<TareaModels> listaTarea = new List<TareaModels>();

            Conexion conexion = new Conexion();
            SqlConnection con = conexion.conexionBD();

            string consulta = "SELECT T.id_tarea, T.nombreTarea FROM Tareas T";
            SqlCommand cmd = new SqlCommand(consulta, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                TareaModels tarea = new TareaModels();

                tarea.id_tarea = Convert.ToInt32(dr["id_tarea"].ToString());
                tarea.nombreTarea = dr["nombreTarea"].ToString();

                listaTarea.Add(tarea);
            }

            return listaTarea;
        }

        //mas consultas sobre tareas unicamente
    }
}