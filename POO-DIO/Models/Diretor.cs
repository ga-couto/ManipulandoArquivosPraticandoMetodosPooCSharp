using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.Models
{
    class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou Diretor.");
        }
    }
}
