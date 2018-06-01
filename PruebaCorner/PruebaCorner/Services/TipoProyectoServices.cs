using PruebaCorner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PruebaCorner.Services
{
    public class TipoProyectoServices
    {
        public List<TipoProyectoModels> ObtenerListadoTiposProyectos()
        {
            List<TipoProyectoModels> listaTipoProyecto = new List<TipoProyectoModels>();

            Conexion conexion = new Conexion();
            SqlConnection con = conexion.conexionBD();

            string consulta = "SELECT TP.id_tipoProyecto, TP.nombreTipoProyecto FROM TipoProyecto TP";
            SqlCommand cmd = new SqlCommand(consulta, con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                TipoProyectoModels tipoProyecto = new TipoProyectoModels();
                tipoProyecto.id_tipoProyecto = Convert.ToInt32(dr["id_tipoProyecto"].ToString());
                tipoProyecto.nombreTipoProyecto = dr["nombreTipoProyecto"].ToString();
                listaTipoProyecto.Add(tipoProyecto);
            }

            con.Close();
            cmd.Dispose();
            dr.Close();

            return listaTipoProyecto;
        }
        

        //mas metodos de consulta solo con tabla de tipos proyectos
    }
}