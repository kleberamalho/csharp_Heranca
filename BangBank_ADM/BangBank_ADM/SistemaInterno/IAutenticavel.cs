using BangBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangBank_ADM.SistemaInterno
{
    public interface Autenticavel
    {
        public bool Autenticar(string senha);
    }
}
