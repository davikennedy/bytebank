namespace bytebank.Titular
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }

        ContaCorrente conta;

        public Cliente()
        {
            TotalClientes += 1;
        }
        
        public static int TotalClientes { get; set; }


    }
}
