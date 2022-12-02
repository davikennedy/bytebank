using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private string _conta;
        public string Conta 
        { 
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                _conta = value;
            }
        }

        private int _numeroAgencia;
        public int NumeroAgencia 
        { 
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _numeroAgencia = value;
            }
        }
        public string NomeAgencia { get; set; }

        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo += value;
            }
        }
        public bool Sacar(double valor)
        {
            if (_saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (_saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                destino._saldo += valor;
                return true;
            }
        }

        public ContaCorrente(Cliente titular, string nomeAgencia, int numeroAgencia, string conta)
        {
            Titular = titular;
            NomeAgencia = nomeAgencia;
            NumeroAgencia = numeroAgencia;
            Conta = conta;
        }

        public static int TotalContasCriadas { get; set; }
    }
}