﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public  class Diretor : Funcionario
    {


        public override double GettBonificacao()
        {

            return this.Salario + base.GettBonificacao();
        }

        public Diretor(string cpf) :base(cpf,5000)   
        {


        }

        public override void AumentoSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
