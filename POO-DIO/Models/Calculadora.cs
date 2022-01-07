using POO_DIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.Models
{
    class Calculadora : ICalculadora
    {
        
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Aqui p baixo implementei automaticamento após utilizar a opção de impleentar.
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

       
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
