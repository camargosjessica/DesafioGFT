using System;
using System.Collections.Generic;

namespace DesafioGFT
{
    class Program
    {
        static Investimento investimento;
        static List<Investimento> investimentoIR;
        static void Main(string[] args)
        {
            investimento = new Investimento();

            investimento.valorInicial = 1000;
            investimento.jurosMensais = 0.04;
            double calcularLucro;
            

            for (int contadorMes = 1; contadorMes <= 2; contadorMes++)
            {
                investimento.valorInicial = investimento.valorInicial + investimento.valorInicial * investimento.jurosMensais;
                calcularLucro = (double)(investimento.valorInicial - 1000);
                Console.WriteLine("Após " + contadorMes + "meses, você terá R$" + calcularLucro);
            }

            //InvestimentoIR


            
            Console.ReadLine();

        }
    }
}
