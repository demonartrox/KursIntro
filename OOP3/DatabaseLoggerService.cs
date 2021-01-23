using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService //sen bir ILoggerService alternatifisin.
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}