using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePaineis.Dados
{
    public class Conexao
    {
        public static string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["Con SQL"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(connectionstring);
        public static void Conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public static void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
