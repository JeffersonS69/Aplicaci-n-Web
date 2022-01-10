using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaDatos
{
    
    public static class Persona
    {
        private static string cadenacon = "server=JEFF\\SQLEXPRESS; database=TI2021; Integrated Security = true";
        public static DataTable getDatos()
        {
            string sql = "Select Cedula, Apellidos, Nombres, FechaNacimiento, Peso " + "from personas order by Apellidos, Nombres";

            SqlConnection conexion = new SqlConnection(cadenacon);
            SqlCommand comando = new SqlCommand(sql,conexion);
            SqlDataAdapter ad = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        public static int insertar(string Cedula, string Nombres, string Apellidos, DateTime FechaNacimiento, double Peso)
        {
            SqlConnection conexion = new SqlConnection(cadenacon);
            string sql = "insert into personas(Cedula, Apellidos, Nombres, FechaNacimiento, Peso) ";
            sql += "values (@cedula, @nombres, @apellidos, @fechanacimiento, @peso)";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add(new SqlParameter("@cedula", Cedula));
            comando.Parameters.Add(new SqlParameter("@nombres", Nombres));
            comando.Parameters.Add(new SqlParameter("@apellidos", Apellidos));
            comando.Parameters.Add(new SqlParameter("@fechanacimiento", FechaNacimiento));
            comando.Parameters.Add(new SqlParameter("@peso", Peso));
            conexion.Open();
            int res = comando.ExecuteNonQuery();
            conexion.Close();
            return res;
        }
    }

    
}
