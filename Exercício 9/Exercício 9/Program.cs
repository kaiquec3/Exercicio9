using System;

namespace Exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Numero();
            var a2 = new Numero();

            Console.Write("Informe o primeiro número: ");
            a1.SetValor(double.Parse(Console.ReadLine()));

            Console.Write("Informe o segundo número: ");
            a2.SetValor(double.Parse(Console.ReadLine()));

            Console.WriteLine((a1.Comparar(a2.GetValor()) == 1) ? "O primeiro número é maior que o segundo"
            : (a1.Comparar(a2.GetValor()) == -1) ? "O segundo número é maior que o primeiro"
            : "Os dois números são idênticos");
        }
    }
}
