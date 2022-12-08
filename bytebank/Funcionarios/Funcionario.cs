using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class  Funcionario
    {
        public string Nome { get; set; }

        public string CPF { get;private set;}

        public double Salario { get; protected set; }

        public static int TotalDeFuncinarios { get; private set; }



        public abstract double GettBonificacao();
       
      
        public Funcionario(string cpf,double salario)
        {
            this.Salario = salario;
            this.CPF= cpf;
            TotalDeFuncinarios++;
            
        }

        public abstract void AumentoSalario();

        



    }
}
