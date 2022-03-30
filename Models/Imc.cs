using static System.Console;
namespace ULTIMOTESTE2.Models
{
    public class Imc
    {
        public void MensagemImc()
        {
            WriteLine("Informe o peso: ");
            double Peso = double.Parse(ReadLine());
            WriteLine("Informe a altura: ");
            double Altura = double.Parse(ReadLine());

            double Resultado = Peso/(Altura*Altura);

            WriteLine($"O IMC calculado é : {Resultado}");
        }
    }
}