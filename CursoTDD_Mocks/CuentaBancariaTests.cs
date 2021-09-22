using NUnit.Framework;

namespace CursoTDD_Mocks
{
    [TestFixture]
    public class CuentaBancariaTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void CuentaBancaria_Depositar_Depositar500()
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria(new Logger());

            Assert.IsTrue(cuentaBancaria.Depositar(500));
            
        }


        [Test]
        public void CuentaBancaria_DepositoGiro_Depositar500Girar300()
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria(new LoggerFake());

            bool deposito = cuentaBancaria.Depositar(500);
            var giro = cuentaBancaria.Girar(300);

            Assert.IsTrue(giro);

        }


    }
}