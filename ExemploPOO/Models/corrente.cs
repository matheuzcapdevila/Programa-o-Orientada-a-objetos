namespace ExemploPOO.Models
{
    public class Corrente : Conta  // Obrigatório sobrescrever o método
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor; //pode usar o this também, mas o base já represneta que é da classe pai
        }
    }
}