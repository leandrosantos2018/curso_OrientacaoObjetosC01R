using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

#region
//Funcionario func = new Funcionario("1561161561",2000);

//func.Nome = "Leandro";

////Console.WriteLine("Digite o CPF do Funcionario: ");
////func.CPF = Console.ReadLine();

////Console.WriteLine("Informe o Salario :");

////func.Salario = Convert.ToDouble( Console.ReadLine());

////double bonus = func.GettBonificacao();

//Console.WriteLine("-------------------------------------");
//Console.WriteLine("Então esse funcionario tem uma boniificação de: ");
//Console.WriteLine("Nome do Funcionario e: " + func.Nome);

//Console.WriteLine("A bonificação do salario é : R$"+ func.GettBonificacao());

//Console.WriteLine("Total de funcionario : QTd :" + Funcionario.TotalDeFuncinarios);


////Console.WriteLine("novo salario");
////Console.WriteLine(func.Salario);

//GerenciadoDeBonificacao gerenciador = new GerenciadoDeBonificacao();
#endregion

CalculoBonificacoes();
 void CalculoBonificacoes()
{
    GerenciadoDeBonificacao gerenciado = new GerenciadoDeBonificacao();

    Designer ulisses = new Designer("12354156");

    ulisses.Nome = "ulisse";

    Diretor paula = new  Diretor("123113121");

    paula.Nome = "Paula Souza";

    Auxiliar Igor = new Auxiliar("564545");
    Igor.Nome = "Igor Dias";

    GerenteDeContas Camila = new GerenteDeContas("7889666");

    Camila.Nome = "Camila";


    gerenciado.Registrar(Camila);
    gerenciado.Registrar(Igor);
    gerenciado.Registrar(paula);
    gerenciado.Registrar(ulisses);

    Console.WriteLine("----- Resumo --------");

    Console.WriteLine("Total de Bonificação = R$" + gerenciado.TotalDeBonificacao);
    Console.WriteLine("Total de Funcionario : "  + Funcionario.TotalDeFuncinarios);
    
    
    //Após torna a class funcionario abstrata não pode ser instanciada
    //Funcionario pedro = new Funcionario();


}

