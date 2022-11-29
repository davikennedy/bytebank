namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
    }
}