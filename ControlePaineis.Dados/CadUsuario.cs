using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlePaineis.Entidades;
using System.Data.SqlClient;

namespace ControlePaineis.Dados
{
    public class CadUsuario
    {
        public Acesso ObterUsuarioESenha(string nomeusuario, string senha)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT * FROM DBUSUARIO WHERE NUSU=@USUARIO AND SENH=@SENHA";
                command.Parameters.AddWithValue("@USUARIO", nomeusuario);
                command.Parameters.AddWithValue("@SENHA", senha);
                Conexao.Conectar();
                var reader = command.ExecuteReader();
                Acesso usuario = null;
                while (reader.Read())
                {
                    usuario = new Acesso();
                    usuario.Nvl_id = Convert.ToInt32(reader["NVL_ID"]);
                    usuario.Usuario = reader["NUSU"].ToString();
                    usuario.Senha = reader["SENH"].ToString();
                }
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
