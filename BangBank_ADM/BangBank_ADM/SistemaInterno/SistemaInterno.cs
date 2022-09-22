using BangBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha) 
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao Bang Bank");
                return true;
            }
            else 
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
