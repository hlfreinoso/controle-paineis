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
    public class Registro
    {
        private LogRegistro _logregistro;
        public LogReg RegistrarLog(string ValIndex, string CodButton, string NomePage, string Usuario)
        {
            _logregistro = new LogRegistro();
            _logregistro.RegistraLogUtilizacao(ValIndex, CodButton, NomePage, Usuario);
            return null;
        }
    }
}
