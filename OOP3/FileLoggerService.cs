using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService //sen bir ILoggerService alternatifisin.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}