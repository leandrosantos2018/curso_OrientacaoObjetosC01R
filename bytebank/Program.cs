using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;


Funcionario func = new Funcionario();

Console.WriteLine("Digite o nome do funcionario: ");

func.Nome = Console.ReadLine();

Console.WriteLine("Digite o CPF do Funcionario: ");
func.CPF = Console.ReadLine();

Console.WriteLine("Informe o Salario :");

func.Salario = Convert.ToDouble( Console.ReadLine());

//double bonus = func.GettBonificacao();

Console.WriteLine("-------------------------------------");
Console.WriteLine("Então esse funcionario tem uma boniificação de: ");
Console.WriteLine("Nome do Funcionario e: " + func.Nome);

Console.WriteLine("A bonificação do salario é : R$"+ func.GettBonificacao());

GerenciadoDeBonificacao gerenciador = new GerenciadoDeBonificacao();



Diretor roberta = new Diretor();

roberta.Nome = "Roberta";
roberta.CPF = "1561161561";
roberta.Salario = 5000;
gerenciador.Registrar(func);
gerenciador.Registrar(roberta);

Console.WriteLine("total de bonificacoes " + gerenciador.TotalDeBonificacao);