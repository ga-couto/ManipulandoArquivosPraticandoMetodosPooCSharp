using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.Models
{
    public abstract class Conta
    {
        protected double Saldo;

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: R$"+ Saldo);
        }

    }
}
