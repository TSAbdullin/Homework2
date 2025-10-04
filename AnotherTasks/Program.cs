using AnotherTasks.Classes;
using AnotherTasks.Structs;

class StartProgram
{
    public static void Main(string[] args)
    {
        List<User> users = new List<User>(); // список, который хранит всех созданных пользователей
        StartProgram startProgram = new StartProgram();

        //////////////////////////////////////
        Console.WriteLine("Задание 1. Выведите на экран информацию о каждом типе данных в виде: Тип данных – максимальное значение – минимальное значение\n");
        startProgram.PrintAllTypesOfData();
        //////////////////////////////////////

        //////////////////////////////////////
        Console.WriteLine("\nЗадание 2. Напишите программу, в которой принимаются данные пользователя в виде имени,\r\nгорода, возраста и PIN-кода. Далее сохраните все значение в соответствующей\r\nпеременной, а затем распечатайте всю информацию в правильном формате.\n");
        try
        {
            startProgram.CreateNewUser(users);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        foreach (User user in users)
        {
            Console.WriteLine(user.ToString()); // выводим всех пользователей
        }
        //////////////////////////////////////

        ////////////////////////////////////////
        Console.WriteLine("Задание 3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на\r\nстрочные.\n");
        Console.Write("Введите строку: ");
        string text = Console.ReadLine(); // исходный текст
        string res = String.Empty; // переменная для хранения конечного текста

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLower(text[i]))
            {
                res += Char.ToUpper(text[i]);
            }
            else
            {
                res += Char.ToLower(text[i]);
            }
        }

        Console.WriteLine(res);
        ////////////////////////////////////////

        ////////////////////////////////////////
        Console.WriteLine("Задание 4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести\r\nна экран.\n");
        startProgram.SearchForSimilarity("aba");
        ////////////////////////////////////////

        ////////////////////////////////////////
        Console.WriteLine("Задание 5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам\r\nнужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически\r\nпокрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),\r\nскидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка\r\nобычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы\r\nсэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов\r\nстерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут\r\nцелыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.\n");
        Console.WriteLine($"Чтобы накопить на отпуск, нужно купить: {startProgram.CalculateAmountOfBottle(10, 10, 50)}\n");
        ////////////////////////////////////////

        Console.WriteLine("Задание 6. Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата\r\nрождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель\r\nвыпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у\r\nстудента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с\r\nразличными параметрами. Посчитать общий объем выпитого, общий объем алкоголя\r\n(процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества\r\nвыпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде\r\nструктуры: наименование типа напитка и процент спирта.\n");

        Drinks beer = new Drinks("Beer", 9);
        Drinks vino = new Drinks("Vino", 15);

        Student student1 = new Student("Kirill", "Safronov", new DateTime(2007, 2, 3), "a", 100, beer);
        Student student2 = new Student("Nazar", "Renov", new DateTime(1999, 12, 6), "b", 50, vino);
        Student student3 = new Student("Margaret", "Rixten", new DateTime(1996, 7, 21), "d", 3, vino);
        Student student4 = new Student("Timur", "Mironov", new DateTime(2008, 2, 6), "c", 25, beer);
        Student student5 = new Student("Alex", "Nazarov", new DateTime(1998, 4, 16), "d", 2, vino);

        double totalVolume = 0;
        double totalAlcohol = 0;

        totalVolume += student1.VolumeOfDrinks;
        totalVolume += student2.VolumeOfDrinks;
        totalVolume += student3.VolumeOfDrinks;
        totalVolume += student4.VolumeOfDrinks;
        totalVolume += student5.VolumeOfDrinks;

        totalAlcohol += student1.VolumeOfDrinks * student1.Drink.PercentOfAlcohol / 100.0;
        totalAlcohol += student2.VolumeOfDrinks * student2.Drink.PercentOfAlcohol / 100.0;
        totalAlcohol += student3.VolumeOfDrinks * student3.Drink.PercentOfAlcohol / 100.0;
        totalAlcohol += student4.VolumeOfDrinks * student4.Drink.PercentOfAlcohol / 100.0;
        totalAlcohol += student5.VolumeOfDrinks * student5.Drink.PercentOfAlcohol / 100.0;

        double s1Alcohol = student1.VolumeOfDrinks * student1.Drink.PercentOfAlcohol / 100.0;
        Console.WriteLine($"{student1.FirstName}:\n" +
            $"Процент выпитой жидкости от общего: {Math.Round(startProgram.CalculatePercentOfVolumeByAllVolume(totalVolume, student1.VolumeOfDrinks), 2)}%\n" +
            $"Процент спирта от общего: {Math.Round(startProgram.CalculatePercentOfAlcoholByAllAlcohol(totalAlcohol, s1Alcohol), 2)}%\n");

        double s2Alcohol = student2.VolumeOfDrinks * student2.Drink.PercentOfAlcohol / 100.0;
        Console.WriteLine($"{student2.FirstName}:\n" +
            $"Процент выпитой жидкости от общего: {Math.Round(startProgram.CalculatePercentOfVolumeByAllVolume(totalVolume, student2.VolumeOfDrinks), 2)}%\n" +
            $"Процент спирта от общего: {Math.Round(startProgram.CalculatePercentOfAlcoholByAllAlcohol(totalAlcohol, s2Alcohol), 2)}%\n");

        double s3Alcohol = student3.VolumeOfDrinks * student3.Drink.PercentOfAlcohol / 100.0;
        Console.WriteLine($"{student3.FirstName}:\n" +
            $"Процент выпитой жидкости от общего: {Math.Round(startProgram.CalculatePercentOfVolumeByAllVolume(totalVolume, student3.VolumeOfDrinks), 2)}%\n" +
            $"Процент спирта от общего: {Math.Round(startProgram.CalculatePercentOfAlcoholByAllAlcohol(totalAlcohol, s3Alcohol), 2)}%\n");

        double s4Alcohol = student4.VolumeOfDrinks * student4.Drink.PercentOfAlcohol / 100.0;
        Console.WriteLine($"{student4.FirstName}:\n" +
            $"Процент выпитой жидкости от общего: {Math.Round(startProgram.CalculatePercentOfVolumeByAllVolume(totalVolume, student4.VolumeOfDrinks), 2)}%\n" +
            $"Процент спирта от общего: {Math.Round(startProgram.CalculatePercentOfAlcoholByAllAlcohol(totalAlcohol, s4Alcohol), 2)}%\n");

        double s5Alcohol = student5.VolumeOfDrinks * student5.Drink.PercentOfAlcohol / 100.0;
        Console.WriteLine($"{student5.FirstName}:\n" +  
            $"Процент выпитой жидкости от общего: {Math.Round(startProgram.CalculatePercentOfVolumeByAllVolume(totalVolume, student5.VolumeOfDrinks), 2)}%\n" +
            $"Процент спирта от общего: {Math.Round(startProgram.CalculatePercentOfAlcoholByAllAlcohol(totalAlcohol, s5Alcohol), 2)}%\n");

        // при необходимости можешь раскомментить:
        Console.WriteLine($"Общий объём выпитого: {totalVolume}");
        Console.WriteLine($"Общий объём чистого спирта: {totalAlcohol:F2}");
    }


    // Выведите на экран информацию о каждом типе данных в виде: Тип данных – максимальное значение – минимальное значение
    void PrintAllTypesOfData() // метод, который выводит информацию об основных типах данных
    {
        Console.WriteLine($"Тип данных sbyte. Минимальное значение: {sbyte.MinValue}, максимальное значение: {sbyte.MaxValue}");
        Console.WriteLine($"Тип данных byte. Минимальное значение: {byte.MinValue}, максимальное значение: {byte.MaxValue}");
        Console.WriteLine($"Тип данных short. Минимальное значение: {short.MinValue}, максимальное значение: {short.MaxValue}");
        Console.WriteLine($"Тип данных ushort. Минимальное значение: {ushort.MinValue}, максимальное значение: {ushort.MaxValue}");
        Console.WriteLine($"Тип данных int. Минимальное значение:  {int.MinValue}, максимальное значение: {int.MaxValue}");
        Console.WriteLine($"Тип данных uint. Минимальное значение: {uint.MinValue}, максимальное значение: {uint.MaxValue}");
        Console.WriteLine($"Тип данных long. Минимальное значение: {long.MinValue}, максимальное значение: {long.MaxValue}");
        Console.WriteLine($"Тип данных ulong. Минимальное значение: {ulong.MinValue}, максимальное значение: {ulong.MaxValue}");
        Console.WriteLine($"Тип данных float. Минимальное значение: {float.MinValue}, максимальное значение: {float.MaxValue}");
        Console.WriteLine($"Тип данных double. Минимальное значение: {double.MinValue}, максимальное значение: {double.MaxValue}");
        Console.WriteLine($"Тип данных decimal. Минимальное значение: {decimal.MinValue}, максимальное значение: {decimal.MaxValue}");
    }

    void CreateNewUser(List<User> users)
    {
        Console.Write("Введите свое имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите свой возраст: ");

        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            throw new FormatException("Неверный формат возраста!");
        }

        Console.Write("Введите город: ");
        string city = Console.ReadLine();

        Console.Write("Введите свой пин-код(4 цифры): ");
        
        if (!short.TryParse(Console.ReadLine(), out short pincode))
        {
            throw new FormatException("Неверный формат пин-кода");
        }

        users.Add(new User(name, age,  pincode, city));
        Console.WriteLine("Пользователь успешно создан!");
    }

    void SearchForSimilarity(string substring)
    {
        Console.Write("Введите строку: ");
        string text = Console.ReadLine();
        int count = 0;

        if (text.Contains(substring))
        {
            for (int i = 0; i <= text.Length - substring.Length; i++)
            {
                if (text.Substring(i, substring.Length) == substring)
                {
                    count++;
                }

            }
        }

        Console.WriteLine($"Количество совпадений {count}");
    }

    int CalculateAmountOfBottle(int normPrice, int salePrice, int holidayPrice)
    {
        double discount = (double)normPrice / 100 * (double)salePrice;

        return holidayPrice / (int)discount;
    }

    double CalculatePercentOfAlcoholByAllAlcohol(double allPercentAlcohol, double volumeOfDrink)
    {
        return volumeOfDrink / allPercentAlcohol * 100;
    }

    double CalculatePercentOfVolumeByAllVolume(double allVolume, double volumeOfDrink)
    {
        return volumeOfDrink/ allVolume * 100;
    } 
}