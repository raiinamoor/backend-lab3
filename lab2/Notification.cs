namespace lab2
{
    public class Notification
    {
        // зависимость от логгера
        ILoggerService _logger;

        // конструктор, устанавливающий зависимость при создании экземпляра класса
        public Notification(ILoggerService logger)
        {
            _logger = logger;
        }

        public void Print(string message)
        {
            Console.WriteLine("Выполняется метод Print() сервиса Notification...");
            _logger.Log(message);
        }
    }
}
