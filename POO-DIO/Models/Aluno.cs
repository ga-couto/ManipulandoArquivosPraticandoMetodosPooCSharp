using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.Models
{
    class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public string Curso { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou aluno e meu nome é {Nome}, tenho {Idade} anos e estou cursando {Curso}. ");
        }
    }
}
