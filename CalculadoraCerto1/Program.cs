using CalculadoraCerto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlCalculadora control = new ControlCalculadora();
            control.Operacao();
            Console.ReadLine();

        }//fim do método main
    }//fim da classe program
}//fim do projeto calculadora

