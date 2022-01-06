using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.Models
{
    class Professor : Pessoa
    {
        public int Salario { get; set; }
        public string CursoMinistrado { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou professor e meu nome é {Nome}, tenho {Idade} anos e recebo R${Salario} reais. ");
        }

    }
}
