namespace lab2
{
    // интерфейс, определяющий зависимость от сервиса, возвращающего текущее время
    public interface ITimeService
    {
        string CurrentTime();
    }

    // реализация зависимости
    public class TimeService : ITimeService
    {
        public string CurrentTime() => DateTime.Now.ToShortTimeString();
    }
}
