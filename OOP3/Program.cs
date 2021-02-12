using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();          
            IKrediManager tasitKrediManager = new TasıtKrediManager(); 
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafkrediManager = new EsnafKredisiManager();
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,loggers);
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };


            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
                                                                    


        }
    }
}
