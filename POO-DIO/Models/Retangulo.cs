using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedida(double comprimento, double largura)
        {
            if (comprimento > 0 && largura >0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                Console.WriteLine("Valor inváçido");
            }
            
        }

        public double ObterArea()
        {
            if (valido)
            {
                return comprimento * largura;
            }
            else
            {
                Console.WriteLine("Valor inválido");
                return 0;
            }
            
            
        }

    }
}
