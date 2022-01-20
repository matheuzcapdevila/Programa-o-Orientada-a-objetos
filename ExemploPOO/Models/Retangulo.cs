// Estudo de encapsulamento
namespace ExemploPOO.Models
{
    public class Retangulo
    {
        // Criação das propriedades em private
        private double comprimento; 
        private double largura;
        private bool valido;

        // Criação do método em public
        public void DefinirMedidas(double comprimento, double largura){
            if (comprimento >0 && largura >0){
            // Colocando os atributos está recebendo como parametro para os privados da classe retangulo
            this.comprimento = comprimento;
            this.largura = largura;
            valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores Invalidos");
            }

        }

        public double ObterArea(){
            if(valido)
            {
            return comprimento * largura;
            }
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
        }
        
    }
}