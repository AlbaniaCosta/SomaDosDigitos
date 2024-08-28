using System;

namespace somadosdigitos
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int digito;
            int soma = 0;

            Console.Write("Digite um número: ");

            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0) {
                digito = numero % 10;
                soma = soma + digito;
                numero = numero / 10;
            }
            Console.WriteLine("Soma = " + soma);
            Console.ReadKey();
        }
    }
}
