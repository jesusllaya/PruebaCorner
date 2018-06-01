using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using PruebaCorner.Models;


namespace PruebaCorner.Services
{
    public class TareasXTipoProyectoServices
    {
        public TareasXTipoProyectoModels listadoTareasXUnTipoProyecto(int id_tipo_proyecto)
        {
            //List<TareasXTipoProyectoModels> listaTareasXTP = new List<TareasXTipoProyectoModels>();
            TareasXTipoProyectoModels tareaXTPM = new TareasXTipoProyectoModels();

            List<TareaModels> listTarea = new List<TareaModels>();
            List<Int32> listPre = new List<int>();

            tareaXTPM.listaTareasEnEsteTipoProyecto = listTarea;
            tareaXTPM.listaNumPreOrdenEnEsteTipoProyecto = listPre;

            /*Conexion conexion = new Conexion();
            SqlConnection con = conexion.conexionBD();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //string consulta = @"SELECT T.id_tarea AS 'Codigo',T.nombreTarea AS 'Tarea' , TTP.numPreOrden AS 'Num.PreOrden' ,TP.nombreTipoProyecto AS 'Tipo Proyecto' FROM TipoProyecto TP JOIN TareasXTipoProyecto TTP ON TP.id_tipoProyecto = TTP.id_tipoProyecto JOIN Tareas T ON TTP.id_tarea = T.id_tarea WHERE TP.id_tipoProyecto = @idTipoProyecto";

            string consulta = @"SELECT T.id_tarea,T.nombreTarea, TTP.numPreOrden,TP.nombreTipoProyecto FROM TipoProyecto TP JOIN TareasXTipoProyecto TTP ON TP.id_tipoProyecto = TTP.id_tipoProyecto JOIN Tareas T ON TTP.id_tarea = T.id_tarea WHERE TP.id_tipoProyecto = @idTipoProyecto";

            cmd.CommandText = consulta;
            cmd.Parameters.AddWithValue("@idTipoProyecto",1);

    */

            Conexion conexion = new Conexion();
            SqlConnection con = conexion.conexionBD();//cambio de nombrepproyecto por id_tipoProyecto
            string consulta = @"SELECT T.id_tarea,T.nombreTarea, TTP.numPreOrden,TP.id_tipoProyecto FROM TipoProyecto TP JOIN TareasXTipoProyecto TTP ON TP.id_tipoProyecto = TTP.id_tipoProyecto JOIN Tareas T ON TTP.id_tarea = T.id_tarea WHERE TP.id_tipoProyecto = @idTipoProyecto";
            SqlCommand cmd = new SqlCommand(consulta,con);
            cmd.Parameters.AddWithValue("@idTipoProyecto", id_tipo_proyecto);
            con.Open();



            SqlDataReader dr = cmd.ExecuteReader();

            //si funciona capas que con un if drread y asigo valor
           
            while (dr.Read())
            {
                //TareasXTipoProyectoModels tareaXTPM = new TareasXTipoProyectoModels();

                tareaXTPM.id_tipoProyecto = Convert.ToInt32(dr["id_tipoProyecto"].ToString());
                TareaModels unaTarea = new TareaModels();
                unaTarea.id_tarea = Convert.ToInt32(dr["id_tarea"].ToString());
                unaTarea.nombreTarea = dr["nombreTarea"].ToString();




                tareaXTPM.listaTareasEnEsteTipoProyecto.Add(unaTarea);

                int numPreOrden = Convert.ToInt32(dr["numPreOrden"].ToString());
                tareaXTPM.listaNumPreOrdenEnEsteTipoProyecto.Add(numPreOrden);
                
            }

            con.Close();
            cmd.Dispose();
            dr.Close();

            return tareaXTPM;
        }
    }
}