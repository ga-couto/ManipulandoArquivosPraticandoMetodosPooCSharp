using POO_DIO.Helper;
using POO_DIO.Interfaces;
using POO_DIO.Models;
using System;
using System.Collections.Generic;
using System.IO;

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

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL A ----------------------------------------");

            Retangulo r = new Retangulo();
            r.DefinirMedida(20, 20);

            Console.WriteLine($"Área {r.ObterArea()}");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL B ----------------------------------------");

            Retangulo r2 = new Retangulo();
            r2.DefinirMedida(0, 0);

            Console.WriteLine($"Área {r2.ObterArea()}");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL C ----------------------------------------");

            Aluno a1 = new Aluno();

            a1.Nome = "Gabriel";
            a1.Idade = 25;
            a1.Curso = "ADS";
            a1.Apresentar();

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL D ----------------------------------------");

            Professor p2 = new Professor();

            p2.Nome = "Gabriel";
            p2.Idade = 25;
            p2.Salario = 3000;
            p2.Apresentar();

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL E ----------------------------------------");

            Calculadora calcular = new Calculadora();

            Console.WriteLine("Resultado da soma de 2 números: " + calcular.Somar(2, 3));
            Console.WriteLine("Resultado da soma de 3 números: " + calcular.Somar(2, 3, 4));

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL F ----------------------------------------");

            ContaCorrente c = new ContaCorrente();

            c.Creditar(1000);
            c.ExibirSaldo();

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL G ----------------------------------------");

            Computador pc = new Computador();

            Console.WriteLine(pc.ToString());

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL H ----------------------------------------");

            ICalculadora calc = new Calculadora();

            Console.WriteLine(calc.Somar(1, 1));


            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL I ----------------------------------------");

            var caminho = "C:\\TESTE";
            FileHelper helper = new FileHelper();

            helper.ListarDiretorios(caminho);

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL J ----------------------------------------");

            var caminhoArq = "C:\\TESTE";
            FileHelper arq = new FileHelper();

            arq.ListarArquivosDiretorios(caminhoArq);

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL J --------------CRIANDO DIRETÓRIO--------------------------");

            var caminhoCri = "C:\\TESTE";
            var caminhoPathCombine = Path.Combine(caminhoCri, "teste 3", "sub teste 3");

            FileHelper cri = new FileHelper();

            Console.WriteLine("Criando diretório..." + caminhoPathCombine);
            cri.CriarDiretorio(caminhoPathCombine);
            Console.WriteLine("Diretórios criados...");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL K ------------------DELETAR DIRETÓRIO COM TUDO Q TIVER DENTRO----------------------");

            //var caminhoDel = "C:\\TESTE";
            //var caminhoPathCombineDel = Path.Combine(caminhoDel, "Teste 1");

            //FileHelper del = new FileHelper();

            //del.ApagarDiretorio(caminhoPathCombineDel,true);


            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL L --------------CRIAR ARQUIVO E ESCREVER DENTRO DELE--------------------------");

            var caminhoCriArq = "C:\\TESTE";            
            var caminhoArquivo = Path.Combine(caminhoCriArq, "arquivo-teste.txt");

            FileHelper criArq = new FileHelper();

            criArq.CriarArquivoTexto(caminhoArquivo, "Olá, teste de escrita no arquivo.");
            Console.WriteLine("Arquivo criado e escrito!");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL M ---------------CRIAR ARQUIVO E ESCREVER DENTRO DELE EM STREAM-------------------------");

            var caminhoCriArqStream = "C:\\TESTE";
            var caminhoArquivoString = Path.Combine(caminhoCriArqStream, "arquivo-teste-stream.txt");
            var ListaString = new List<string>{"Linha 1", "Linha 2", "Linha 3"};

            FileHelper criArqString = new FileHelper();


            criArqString.CriarArquivoTextoStream(caminhoArquivoString, ListaString);

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL N ---------------ADICIONAR LINHAS NUM ARQUIVO (STREAM)-------------------------");

            var caminhoCriArqStreamAddTexto = "C:\\TESTE";
            var caminhoArquivoStream = Path.Combine(caminhoCriArqStreamAddTexto, "arquivo-teste-stream.txt");
            var ListaString2 = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var ListaString2Continuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6", "Linha 7" };

            FileHelper addArqTexto = new FileHelper();


            addArqTexto.CriarArquivoTextoStream(caminhoArquivoStream, ListaString2);
            addArqTexto.AdicionarTextoStream(caminhoArquivoStream, ListaString2Continuacao);


            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL O ----------------------------------------");


            var caminhoLerArqStream = "C:\\TESTE\\Teste 1";
            var caminhoLerArquivoStream = Path.Combine(caminhoLerArqStream, "arquivo-teste-stream.txt");
            

            FileHelper lerArq = new FileHelper();

            lerArq.LerArquivoStream(caminhoLerArquivoStream);

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL P ----------------------------------------");

            var caminhoMoverArq = "C:\\TESTE\\Teste 1";
            var caminhoMoverArq2 = "C:\\TESTE\\Teste 2";
            var caminhoMoverArquivo = Path.Combine(caminhoMoverArq, "arquivo-teste-stream-mover.txt");
            var novoCaminhoMoverArquivo = Path.Combine(caminhoMoverArq2, "arquivo-teste-stream-mover-renomeado.txt");


            FileHelper movArq = new FileHelper();

            movArq.MoverArquivo(caminhoMoverArquivo, novoCaminhoMoverArquivo);


            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL Q ----------------------------------------");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL R ----------------------------------------");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL S ----------------------------------------");

            Console.WriteLine("---------BARA DE SEPARAÇÃO VISUAL T ----------------------------------------");




        } 
    }

}