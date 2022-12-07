﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public string CPF { get;set;}

        public double Salario { get; set; }

        public static int TotalDeFuncinarios { get; private set; }



        public virtual double GettBonificacao()
        {

            return this.Salario * 0.10;
        }

      
        public Funcionario()
        {
            TotalDeFuncinarios++;

        }
        



    }
}
