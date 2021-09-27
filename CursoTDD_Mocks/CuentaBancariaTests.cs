using Moq;
using NUnit.Framework;

namespace CursoTDD_Mocks
{
    [TestFixture]
    public class CuentaBancariaTests
    {

        private CuentaBancaria cuentaBancaria;
        Mock<ILogger> loggerMock = new Mock<ILogger>();
       
        [SetUp]
        public void SetUp()
        {
            cuentaBancaria = new(loggerMock.Object);
        }

        [Test]
        public void CuentaBancaria_Depositar_Depositar500()
        {
            Assert.IsTrue(cuentaBancaria.Depositar(500));
        }


        [Test]
        public void CuentaBancaria_DepositoGiro_Depositar500Girar300()
        {
            //loggerMock.Setup(x => x.LogSaldoDespuesDeUnGiro(It.IsAny<int>())).Returns(true);
            loggerMock.Setup(x => x.LogSaldoDespuesDeUnGiro(It.Is<int>(i => i >= 0))).Returns(true);


            bool deposito = cuentaBancaria.Depositar(500);
            var giro = cuentaBancaria.Girar(300);
            Assert.IsTrue(giro);

        }

        [Test]
        public void CuentaBancaria_DepositoGiro_Depositar500Girar800_ReturnsFalse()
        {
            //loggerMock.Setup(x => x.LogSaldoDespuesDeUnGiro(It.IsAny<int>())).Returns(true);
            loggerMock.Setup(x => x.LogSaldoDespuesDeUnGiro(It.Is<int>(i => i >= 0))).Returns(true);


            bool deposito = cuentaBancaria.Depositar(500);
            var giro = cuentaBancaria.Girar(800);
            Assert.IsFalse(giro);

        }

        [Test]
        public void MockLogger_MessageQueRetornaUnStr_Message()
        {
            string resultadoEsperado = "HOLA";

            loggerMock.Setup(x => x.MessageQueRetornaUnStr(It.IsAny<string>())).Returns((string str) => str.ToUpper());

            Assert.That(loggerMock.Object.MessageQueRetornaUnStr("hola"), Is.EqualTo(resultadoEsperado));
            
            //LOGICA DE NEGOCIO DEL METODO (SI ES QUE APLICA)

        }

        [Test]
        public void MockLogger_LogConUnOutput_Message()
        {
            string outputEsperado = "";

            loggerMock.Setup(x => x.LogConUnOutput(It.IsAny<string>(), out outputEsperado)).Returns(true);

            string resultado = "";

            Assert.IsTrue(loggerMock.Object.LogConUnOutput("INPUT", out resultado));

            Assert.That(resultado, Is.EqualTo(outputEsperado));

        }


    }
}