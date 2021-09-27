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
                _logger.LogABaseDeDatos("Monto Girado " + monto.ToString());
                saldo -= monto;
                return _logger.LogSaldoDespuesDeUnGiro(saldo);
            }
            return _logger.LogSaldoDespuesDeUnGiro(saldo-monto);
        }

        public int ConsultarSaldo()
        {
            return saldo;
        } 
    }
}
