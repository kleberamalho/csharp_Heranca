﻿using BangBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangBank_ADM.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public override double getBonificacao()
        {
            return Salario * 0.5;
        }
        public Diretor(string cpf):base(cpf, 5000)
        {
            Console.WriteLine("Criando um diretor.");
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
        //public string Senha { get; set; }
        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}
    }
}
