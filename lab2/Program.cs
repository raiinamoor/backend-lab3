using Microsoft.Extensions.DependencyInjection;
using lab2;

// контейнер для определения зависимостей
var services = new ServiceCollection();

// зависимости определяются и добавляются в контейнер.
// в <> указывается зависимость (интерфейс) и класс, который будет использоваться
// в качестве реализации этой зависимости.
// Transient означает, что при каждом обращении к сервису будет создаваться новый экземпляр класса
services.AddTransient<ILoggerService, ConsoleLoggerWithTime>();
// services.AddTransient<ILoggerService, ConsoleLogger>(); // если убрать комментарий, во всех местах, где используется ILoggerService, будет использоваться ConsoleLogger т.к. он последний
services.AddTransient<ITimeService, TimeService>();
services.AddTransient<Notification>();

// контейнер ServiceCollection преобразуется в IoC-контейнер ServiceProvider.
// все определённые зависимости (интерфейсы) инициализируются классами, описанными ранее
var serviceProvider = services.BuildServiceProvider();

// при использовании GetRequiredService генерируется исключение,
// если сервис указанного типа не найден, поэтому производится проверка на исключения
try
{
    // получение зависимостей
    serviceProvider.GetRequiredService<Notification>().Print("This is a test message.");
}
catch (Exception e)
{
    Console.WriteLine($"Exception caught: {e.Message}");
}

