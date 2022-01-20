using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;

namespace ExemploPOO {
    class Program{
        static void Main(string[] args) =>
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

            

            







}
}