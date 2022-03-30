using static System.Console;
namespace ULTIMOTESTE2.Models
{
    public class Idade
    {   
        public void MensagemIdade()
        {
            WriteLine("Informe sua data de nascimento:  ");
            int nascimento = int.Parse(ReadLine());

            WriteLine("Informe o ano atual:  ");
            int AnoAtual = int.Parse(ReadLine());
            
            int Idade = AnoAtual - nascimento;
            WriteLine($"A idade é: {Idade} anos.");
        }
    }
}