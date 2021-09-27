using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD_Mocks
{
    public interface ILogger
    {
        void Message(string message);

        bool LogABaseDeDatos(string message);

        bool LogSaldoDespuesDeUnGiro(int saldoDespuesDeUnGiro);

        string MessageQueRetornaUnStr(string message);

        bool LogConUnOutput(string message, out string outputMessage);
    }

    public class Logger : ILogger
    {
        public bool LogABaseDeDatos(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public bool LogConUnOutput(string message, out string outputMessage)
        {
            outputMessage = "Hola " + message;
            return true;
         }

        public bool LogSaldoDespuesDeUnGiro(int saldoDespuesDeUnGiro)
        {
            if (saldoDespuesDeUnGiro >= 0)
            {
                Console.WriteLine("Giro Exitoso");
                return true;
            }
            Console.WriteLine("Giro no Realizado");
            return false;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public string MessageQueRetornaUnStr(string message)
        {
            Console.WriteLine(message);
            return message.ToUpper();
        }
    }
}
