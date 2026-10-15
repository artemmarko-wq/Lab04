static void Main(string[] args)
{
    // Налаштування кодування для виведення українського тексту
    Console.OutputEncoding = System.Text.Encoding.UTF8;

    // Введення номера дня тижня
    Console.Write("Введіть номер дня тижня (1-7): ");
    int day = Convert.ToInt32(Console.ReadLine());

    // Введення номера пари
    Console.Write("Введіть номер пари (1-6): ");
    int pair = Convert.ToInt32(Console.ReadLine());

    // Перевірка правильності введених значень
    if (day < 1 || day > 7 || pair < 1 || pair > 6)
    {
        // Виведення повідомлення про помилку
        Console.WriteLine("Помилка! Введіть правильні значення.");
    }
    else
    {
        // Визначення назви дня тижня за допомогою switch
        string dayName = day switch
        {
            1 => "Понеділок",
            2 => "Вівторок",
            3 => "Середа",
            4 => "Четвер",
            5 => "П'ятниця",
            6 => "Субота",
            7 => "Неділя",
            _ => "Невідомий день"
        };

        // Визначення часу початку пари
        string time = pair switch
        {
            1 => "08:30",
            2 => "10:15",
            3 => "12:00",
            4 => "13:00",
            5 => "14:45",
            6 => "16:30",
            _ => "Невідомий час"
        };

        // Виведення назви дня тижня
        Console.WriteLine("День тижня: " + dayName);

        // Перевірка, чи є день вихідним
        if (day == 6 || day == 7)
        {
            Console.WriteLine("Це вихідний день.");
        }
        else
        {
            Console.WriteLine("Це навчальний день.");
        }

        // Виведення часу початку пари
        Console.WriteLine("Початок пари: " + time);
    }
}
    }
}
