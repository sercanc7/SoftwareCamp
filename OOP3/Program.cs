namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interfaceler'de implement ettiği classın referans numarasını tutabilir.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();   
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            
            // Log metodu (ILoggerService'den gelen metod)
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
          
            // Loglardan gelen çoklu logu listeler(Fileloggerservice,DatabaseLoggerService)
            List<ILoggerService> loggers = new List<ILoggerService>() { new FileLoggerService(),new DatabaseLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,loggers);
            

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}