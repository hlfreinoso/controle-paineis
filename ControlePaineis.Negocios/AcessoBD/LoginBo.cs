using ControlePaineis.Dados;
using ControlePaineis.Negocios.Excepions;
using ControlePaineis.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePaineis.Negocios.AcessoBD
{
    public class LoginBo
    {
        private CadUsuario _cadusuario;
        public Acesso UsuarioCadastrado(string nomeusuario, string senha)
        {
            _cadusuario = new CadUsuario();
            var usuario = _cadusuario.ObterUsuarioESenha(nomeusuario, senha);
            if (usuario == null)
            {
                throw new UsuarioNaoCadastradoException();
            }
            else
            {
                return usuario;
            }
        }
    }
}
