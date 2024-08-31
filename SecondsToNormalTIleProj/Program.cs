
internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Будете вводить секунды (1) или минуты (2)?");
    int answer;
    while (int.TryParse(Console.ReadLine(), out answer) == false || (answer != 1 && answer != 2))
    {
       Console.WriteLine("Введите 1 или 2:");
    }
    switch (answer)
    {
      case 1: PrintFromSeconds(); break;
      case 2: PrintFromMinutes(); break;
    }

      static void PrintFromSeconds()
    {
      decimal seconds = 0;
      Console.WriteLine("Введите количество секунд:");
      seconds = 0;
      while (decimal.TryParse(Console.ReadLine(), out seconds) == false)
      {
        Console.WriteLine("Введите количество секунд:");
      }

      long hours = ((long)seconds / 3600);
      long minutes = (long)seconds % (hours * 3600)/60;
      seconds = seconds % 60;
      
      Console.WriteLine("Часов: {0:0.}\nМинут: {1:0.}\nСекунд: {2:0.}", hours, minutes, seconds);
    }
  }

  private static void PrintFromMinutes()
  {
    decimal minutes = 0;
    Console.WriteLine("Введите количество минут:");
    
    while (decimal.TryParse(Console.ReadLine(), out minutes) == false)
    {
      Console.WriteLine("Введите количество минут:");
    }

    decimal hours = minutes / 60;
    minutes = minutes % 60;
    decimal seconds = 0;
    Console.WriteLine("Часов: {0:0.}\nМинут: {1:0.}\nСекунд: {2:0.}", hours, minutes, seconds);
  }
}