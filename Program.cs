using ULTIMOTESTE2.Models;
using static System.Console;
namespace ULTIMOTESTE2
{
      class program
      {
            public static void Main(string[]args)
            {     WriteLine("Escolha uma das opções abaixo: "+
            "\n[1] Idade "+"\n[2] Imc "+"\n[3]Sair");

                  int Opcao = int.Parse(ReadLine());
                  switch(Opcao)
                  {     case 1:
                        Idade idade = new Idade();
                        idade.MensagemIdade();
                        break;

                        case 2:
                        Imc imc = new Imc();
                        imc.MensagemImc();
                        break;

                        case 3:
                        WriteLine("Obigado por utilizar nosso app.");
                        break;

                        default:
                        WriteLine("Opção inválida!");
                        break;
                  }

                  
            }
      }    
}