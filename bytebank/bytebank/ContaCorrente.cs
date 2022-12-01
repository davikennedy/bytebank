using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        private double _saldo;

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

        /*public void Set_saldo(double valor)
         {
             if (valor < 0)
             {
                 return;
             }
             _saldo += valor;
         }

         public double Get_saldo()
         {
             return _saldo;
         }*/
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
    }
}