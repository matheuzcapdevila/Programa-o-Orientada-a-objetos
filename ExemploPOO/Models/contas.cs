namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor); //é obrigado a sobrescrever

        public void ExibirSaldo(){ // não é obrigado a sobrescrever
            System.Console.WriteLine("Seu saldo é" + saldo);
        }

        


    }
}