namespace CursoTDD_Mocks
{
    public class CuentaBancaria
    {
        public int saldo;
        private readonly ILogger _logger;



        public CuentaBancaria(ILogger logger)
        {
            _logger = logger;
            saldo = 0;
        }


        public bool Depositar(int monto)
        {
            _logger.Message("Comienza Depósito");
            saldo += monto;
            return true;
        }

        public bool Girar(int monto)
        {
            if(saldo - monto >= 0)
            {
                saldo -= monto;
                return true;
            }
            return false;
        }


        public int ConsultarSaldo()
        {
            return 0;
        } 

    }
}
