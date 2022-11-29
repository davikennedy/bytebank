namespace bytebank
{
    public class ContaCorrente
    {
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

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }
    }
}