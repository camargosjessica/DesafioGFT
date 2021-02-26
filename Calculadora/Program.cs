using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            int num;
            int resultado = 0;
                    

            while (resultado <= 300)
            {
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                //
                if (num <= 300)
                    break;

                Console.WriteLine("A somatoria é: " + num);
            }

            Console.ReadLine();
        }
    }
}
