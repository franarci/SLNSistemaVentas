using Datos.Models;
using Datos.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmVendedor
    {
        public static List<Vendedor> Listar()
        {
            string consulta = "SELECT Id,Nombre,Apellido,DNI,Comision FROM dbo.Vendedor";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
            SqlDataReader reader;

            reader = comando.ExecuteReader();


            List<Vendedor> lista = new List<Vendedor>();

            while (reader.Read())
            {
                lista.Add(
                    new Vendedor(
                        
                        reader["Nombre"].ToString(),
                        reader["Apellido"].ToString(),
                        reader["DNI"].ToString(),
                        Convert.ToDecimal(reader["Comision"]),
                        Convert.ToInt32(reader["Id"])
                        ));
            }
            AdminDB.ConectarBase().Close();
            return lista;
        }

        public static DataTable TraerPorId(int id)
        {
            string querySql = "SELECT Id,Nombre,Apellido,DNI,Comision FROM dbo.Vendedor WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;


            DataSet ds = new DataSet();
            adapter.Fill(ds, "Vendedor");

            AdminDB.ConectarBase().Close();
            return ds.Tables["Vendedor"];
        }

        public static int Insertar(Vendedor vendedor)
        {
            string consulta = "INSERT INTO dbo.Vendedor(Nombre,Apellido,DNI,Comision)VALUES(@Nombre ,@Apellido,@DNI,@Comision)";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());


            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
            adapter.SelectCommand.Parameters.Add("@DNI", SqlDbType.Char,11).Value = vendedor.Dni;
            adapter.SelectCommand.Parameters.Add("@Comision", SqlDbType.Decimal).Value = vendedor.Comision;

            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static DataTable TraerVendedores(decimal comision)
        {
            string consultaSQL = "SELECT Id,Nombre,Apellido,DNI,Comision from dbo.Vendedor WHERE Comision=@Comision";

            SqlConnection conexion = AdminDB.ConectarBase();

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, conexion);


            adapter.SelectCommand.Parameters.Add("@Comision", SqlDbType.Decimal).Value = comision;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Comision");

            AdminDB.ConectarBase().Close();
            return ds.Tables["Comision"];
        }

        public static int Modificar(Vendedor vendedor)
        {
            string consulta = "UPDATE dbo.Vendedor SET Nombre = @Nombre ,Apellido = @Apellido, DNI = @DNI, Comision = @Comision WHERE Id = @Id";


            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
            adapter.SelectCommand.Parameters.Add("@DNI", SqlDbType.Char, 11).Value = vendedor.Dni;
            adapter.SelectCommand.Parameters.Add("@Comision", SqlDbType.Decimal).Value = vendedor.Comision;
            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = vendedor.Id;

            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }
        public static int Eliminar(int id)
        {
            string consulta = "DELETE FROM dbo.Vendedor WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }
    }
}
