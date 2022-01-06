using POO_DIO.Models;
using System;

namespace POO_DIO
{
    class Program
    {
        static void Main(string[] args)
        {


            //p1 é um objeto do tipo pessoa
            Pessoa p1 = new Pessoa();

            p1.Nome = "Gabriel";
            p1.Idade = 25;

            p1.Apresentar();

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL----------");
           
            Retangulo r = new Retangulo();
            r.DefinirMedida(20, 20);

            Console.WriteLine($"Área {r.ObterArea()}");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL----------");

            Retangulo r2 = new Retangulo();
            r2.DefinirMedida(0, 0);

            Console.WriteLine($"Área {r2.ObterArea()}");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL----------");

            Aluno a1 = new Aluno();

            a1.Nome = "Gabriel";
            a1.Idade = 25;
            a1.Curso = "ADS";
            a1.Apresentar();

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL----------");

           Professor p2 = new Professor();

            p2.Nome = "Gabriel";
            p2.Idade = 25;
            p2.Salario = 3000;
            p2.Apresentar();

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL----------");

            Calculadora calc = new Calculadora();

            Console.WriteLine("Resultado da soma de 2 números: " + calc.Somar(2,3));
            Console.WriteLine("Resultado da soma de 3 números: " + calc.Somar(2, 3,4));

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL----------");

            ContaCorrente c = new ContaCorrente();

            c.Creditar(1000);
            c.ExibirSaldo();


        } 
    }

}