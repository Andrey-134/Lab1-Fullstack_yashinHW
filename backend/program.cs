// See https://aka.ms/new-console-template for more information
string name=Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine($"Сегодня {DateTime.Now.DayOfWeek}");
Console.Write("Хотите продолжить? (y/n): ");
string answer = Console.ReadLine()?.Trim().ToLower();

if (answer == "y" || answer == "yes")
    Console.WriteLine("Отлично!");
else
    Console.WriteLine("До свидания!");