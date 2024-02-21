namespace lab2
{
    // интерфейс, определяющий зависимость от сервиса, логгирующего данные
    public interface ILoggerService
    {
        void Log(string message);
    }

    // реализация зависимости с простым выводом сообщения в консоль
    public class ConsoleLogger : ILoggerService
    {
        public void Log(string message) => Console.WriteLine(message);
    }
    
    // реализация зависимости с выводом в консоль сообщения и текущего времени
    public class ConsoleLoggerWithTime : ILoggerService
    {
        // зависимость
        ITimeService _timeService;

        // конструктор, устанавливающий зависимость при создании экземпляра класса
        public ConsoleLoggerWithTime(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public void Log(string message) => 
            Console.WriteLine($"Message at {_timeService.CurrentTime()}: {message}");
    }
}
