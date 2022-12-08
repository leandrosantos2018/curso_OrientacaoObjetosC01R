using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public  class GerenteDeContas : Funcionario
    {


        public override double GettBonificacao()
        {

            return this.Salario + base.GettBonificacao();
        }

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {


        }

        public override void AumentoSalario()
        {
            this.Salario *= 0.5;
        }
    }
}
