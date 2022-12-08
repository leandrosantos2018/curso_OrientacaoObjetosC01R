using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public  class Auxiliar :  Funcionario
    {


        public override double GettBonificacao()
        {

            return this.Salario + base.GettBonificacao();
        }

        public Auxiliar(string cpf) : base(cpf, 2000)
        {


        }

        public override void AumentoSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
