using System;
using System.Collections.Generic;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;

namespace ExemploPOO {
    class Program{
        static void Main(string[] args) {

            var caminho = "C:\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "subpasta1"); // Combine, faz de uma maneira que não precise se preocupar com os caminhos das pastas, barras
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");

            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 3", "arquivo-teste.txt"); //Pode especificar outro nome


            var listaString = new List<string> {"Linha 1", "Linha2","Linha3"};
            var listaStringContinuação = new List<string> {"Linha 4", "Linha5","Linha6"};

            FileHelper helper = new FileHelper();
            //FileHelper helper = new FileHelper();
            //  helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);
            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo,"Olá, Teste de escrita de arquivo");
            // helper.CriarArquivoStream(caminhoArquivo,  listaString);
            // helper.AdicionarTextoArquivoStream(caminhoArquivo, listaStringContinuação);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);



            // Abstração:
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar(); 

            // Retangulo r = new Retangulo();
            // Retangulo r2 = new Retangulo();
            // r.comprimento = 3;
            // Desse modo não é possível já que as propriedades estão como privadas
            // Assim usa-se o método, que é público:

            // r.DefinirMedidas(30,30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // r2.DefinirMedidas(0,0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            //Herança:

            // Aluno p1 = new Aluno();

            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota=10;


            // p1.Apresentar();

            // Professor p2 = new Professor();

            // p2.Nome = "Jack";
            // p2.Idade = 20;
            // p2.Salario = 5000;

            // p2.Apresentar();

            // Aluno e professor herdou os atributos e os métodos de Pessoas

            // Tempo de compilaçao:

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma:" + calc.Somar(10,10));
            // System.Console.WriteLine("Resultado da primeira soma:" + calc.Somar(10,10,10));

            //Classes abstratas:

            // Conta conta = new Conta(); não dá

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            // Computador comp = new Computador();

            // System.Console.WriteLine(comp.ToString());

            //Interfaces não podem inicializar instancias, como as abstratas

            //iCalculadora calc = new Calculadora();

            //Manipulando arquivos

           
        }



            







}
}