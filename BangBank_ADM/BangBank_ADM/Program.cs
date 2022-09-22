using BangBank_ADM.Funcionarios;
using BangBank_ADM.SistemaInterno;
using BangBank_ADM.Utilitario;

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao() 
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Desenvolvedor kleber = new Desenvolvedor("41344986376");
    kleber.Nome = "Kleber";

    Designer renan = new Designer("420.429.867-66");
    renan.Nome = "Renan";

    Diretor rioner = new Diretor("512.065.969-69");
    rioner.Nome = "Rioner";

    Auxiliar andre = new Auxiliar("516.781.330-97");
    andre.Nome = "André";

    GerenteDeContas fernando = new GerenteDeContas("225.675.220-51");
    fernando.Nome = "Fernando";

    gerenciador.Registrar(renan);
    gerenciador.Registrar(rioner);
    gerenciador.Registrar(andre);
    gerenciador.Registrar(fernando);
    gerenciador.Registrar(kleber);

    Console.WriteLine("Total de bonificação: " +gerenciador.getBonificacao());

}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberto = new Diretor("512.065.969-69");
    roberto.Nome = "Rioner";
    roberto.Senha = "123";

    GerenteDeContas Ursula = new GerenteDeContas("225.675.220-51");
    Ursula.Nome = "Fernando";
    Ursula.Senha = "321";

    //Funcionario pedro = new Designer("696.675.334-51");
    //pedro.Nome = "Pedro";
    //pedro.Senha = "123";

    //sistemaInterno.Logar(pedro, "123");
    sistemaInterno.Logar(roberto, "123");
    sistemaInterno.Logar(Ursula, "123");

}

Console.ReadKey();