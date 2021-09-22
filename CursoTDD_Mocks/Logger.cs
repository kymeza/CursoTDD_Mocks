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
    }

    public class Logger : ILogger
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class LoggerFake : ILogger
    {
        public void Message(string message) { }

    }


    
}
