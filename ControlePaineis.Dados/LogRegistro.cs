using System;
using System.Data.SqlClient;

namespace ControlePaineis.Dados
{
    public class LogRegistro
    {
        public void RegistraLogUtilizacao(string ValIndex, string CodButton, string NomePage, string Usuario)
        {
            try
            {
                SqlCommand comando = new SqlCommand("INSERT INTO DBREGISTRO (INDX, NBTN, PAGE, NUSU) VALUES (@indx, @nbtn, @page, @nusu)", Conexao.connection);
                comando.Parameters.Add(new SqlParameter("@indx", ValIndex));
                comando.Parameters.Add(new SqlParameter("@nbtn", CodButton));
                comando.Parameters.Add(new SqlParameter("@page", NomePage));
                comando.Parameters.Add(new SqlParameter("@nusu", Usuario));
                Conexao.connection.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.connection.Close();
            }
        }
    }
}
