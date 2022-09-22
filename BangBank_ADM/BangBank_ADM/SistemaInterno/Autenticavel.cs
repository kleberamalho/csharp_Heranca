﻿using BangBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangBank_ADM.SistemaInterno
{
    public abstract class Autenticavel: Funcionario
    {
        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

        //public override double getBonificacao()
        //{
        //    return 0;
        //}
        //public override void AumentarSalario()
        //{
        //    Console.WriteLine("Implementar AumentarSalario.");
        //}
    }
}
