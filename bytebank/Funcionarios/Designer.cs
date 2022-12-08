using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        public override double GettBonificacao()
        {

            return this.Salario + base.GettBonificacao();
        }


        public override void AumentoSalario()
        {
            this.Salario *= 1.11;
        }

    }
}
