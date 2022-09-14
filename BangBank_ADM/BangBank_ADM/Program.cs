using BangBank_ADM.Funcionarios;
using BangBank_ADM.Utilitario;

Console.WriteLine("BangBank!!!");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario renan = new Funcionario();
renan.Nome = "Renan";
renan.Cpf = "874455631";
renan.Salario = 2000;

//Console.WriteLine("Nome: " + renan.Nome);
//Console.WriteLine("CPF: " + renan.Cpf);
//Console.WriteLine("Salario: " + renan.Salario);

Diretor rioner = new Diretor();
rioner.Nome = "Rioner";
rioner.Cpf = "69875324";
rioner.Salario = 5000;

Console.WriteLine("Bonificação: " +renan.getBonificacao());
Console.WriteLine("Bonificação: " + rioner.getBonificacao());

gerenciador.Registrar(renan);
gerenciador.Registrar(rioner);

Console.WriteLine("Total de bonificacao: " + gerenciador.getBonificacao());

Console.ReadKey();