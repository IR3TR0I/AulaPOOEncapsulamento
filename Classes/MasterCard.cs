namespace AULAPOO_ENCAPSULAMENTO.Classes
{
    public class MasterCard
    {
        private int parcelas;
        private bool limite;

        public string NomeTitular { get; internal set; }
        public string Bandeira { get; internal set; }
        public string Numero { get; internal set; }
        public string CVV { get; internal set; }
        public object Token { get; internal set; }
        public object Limite { get; internal set; }

        public void MostrarLimite(){
            System.Console.WriteLine(this.limite);
        }
    }
}