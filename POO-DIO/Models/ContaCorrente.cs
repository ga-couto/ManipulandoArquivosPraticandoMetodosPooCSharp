using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.Models
{
    class ContaCorrente : Conta
    {
        public override void Creditar(double valor)
        {
            //this.Saldo = valor;
            base.Saldo = valor;
            
        }
    }
}
