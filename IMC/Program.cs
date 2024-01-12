using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticas.IMC
{
    class Program
    {

        static void Main(string[] args)
        {

            Pessoa a = new Pessoa();

            Console.WriteLine("Informe seu peso:");
            a.peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informa sua altura:");
            a.altura = Convert.ToDouble(Console.ReadLine());

            a.mensagem();


        }




    }
}
