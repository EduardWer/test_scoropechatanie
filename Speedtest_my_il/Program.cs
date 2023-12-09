namespace Speedtest_my_il;



/*
 * Я не очень понял куда засунуть сохранение в json
 * Функции есть но я хз куда это пихать 
 */
internal class Program
{
    private static readonly Json_function function = new();

    private static readonly string text =
        "Мягкая мелодия рассеянно звучит в комнате. Музыкальный инструмент обволакивает пространство нежными звуками. " +
        "Ноты разливаются в воздухе, проникая в самые глубины души. Для музыканта эта мелодия - выражение его внутреннего мира. " +
        "Он переживает каждую ноту, каждую фразу, словно открывает свое сердце перед слушателями. " +
        "Аудитория сидит в полном молчании, погруженная в гармонию звуков. Все проникаются этой музыкой, она становится частью их самого. " +
        "В этот момент время останавливается, мир замирает, а только музыка продолжает звучать. " +
        "Словно волшебство, она способна перенести людей в другое измерение, открыть им новые миры и эмоции. " +
        "Мелодия становится важной частью жизни, спутником в радости и горе. " +
        "Музыка объединяет людей, пронизывает все сферы существования. " +
        "Она несет в себе энергию и силу, которые помогают нам преодолевать трудности и наслаждаться самой жизнью.";

    private static ConsoleKeyInfo keyInfo;
    private static readonly User user = new();
    private static int num_int;
    private static bool run = true;

    private static void Main()
    {
        while (keyInfo.Key != ConsoleKey.F1)
        {
            function.Show_Json();
            Console.WriteLine("Введите ваше имя: ");
            user.UserName = Console.ReadLine();
            Speed();
            keyInfo = Console.ReadKey();
            Console.SetCursorPosition(0, 0);
        }
    }

    private static void Speed()
    {
        Time();

        while (run == true)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(text);
            Console.SetCursorPosition(0, 0);

            while (num_int < text.Length)
            {
                var key = Console.ReadKey(true).KeyChar;
                if (key == text[num_int])
                {
                    num_int++;
                    Ny_tipo_class(num_int);
                }
            }
        }
    }

    private static void Time()
    {
        var thread = new Thread(_ =>
        {
            var top = 8;
            var dateTime = DateTime.Now;
            var timer = dateTime.AddMinutes(-1);

            while (dateTime >= timer && run)
            {
                Console.SetCursorPosition(0, top);
                if (num_int == text.Length) run = false;
                Console.SetCursorPosition(0, top);
                var ticks = (dateTime - timer).Ticks;
                Console.SetCursorPosition(0, top);
                Console.WriteLine(new DateTime(ticks).ToString("ss"));
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, top);
                timer = timer.AddSeconds(1);
                Console.SetCursorPosition(0, top);
            }

            Console.Clear();
            Console.WriteLine("Ваше время вышло");
            user.Speed_minute = num_int;
            user.Second = num_int / 60;
            try
            {
                keyInfo = Console.ReadKey();
                while (keyInfo.Key != ConsoleKey.Escape)
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.Clear();
                            Console.WriteLine($"Имя: {user.UserName}");
                            Console.WriteLine($"Скорость в минуту: {user.Speed_minute} ");
                            Console.WriteLine($"Скорость в секунду: {user.Second} ");
                            Console.WriteLine("---------------------------------------------------");

                            

                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("В начало - Esp");
                            Console.WriteLine("Закончить - D");
                            break;
                        case ConsoleKey.Escape:
                            Main();
                            break;
                        case ConsoleKey.D:
                            Environment.Exit(0);
                            break;
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        });
        thread.Start();
    }


    private static void Ny_tipo_class(int lenght)
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Red;
        for (num_int = 0; num_int < lenght; num_int++) ;
        Console.Write(text[num_int]);
        Console.SetCursorPosition(0, 0);
    }
}