using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace PruebaCorner.Services
{
    public class Conexion
    {
        //string cade = "Data Source=JESUSLLAYA\\SQLEXPRESS;Initial Catalog=GloboGroup;Integrated Security=True";
       // static string cadena_conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string cade2 = "Data Source=JESUSLLAYA\\SQLEXPRESS;Initial Catalog=PruebaAgil;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        SqlConnection cn;

        public SqlConnection conexionBD()
        {
            cn = new SqlConnection(cade2);
            return cn;
        }
    }
}