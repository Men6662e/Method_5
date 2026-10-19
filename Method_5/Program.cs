//=========================================================================================================================================================================================

//double[] temps = { 3.5, -2.0, 0.0, 7.2, -5.5, 4.0, 1.5 };

//PrintTemps(temps);

//double average = CalculateAverage(temps);
//double maxTemp = FindMax(temps);
//double minTemp = FindMin(temps);
//int belowZeroCount = CountBelowZero(temps);

//Console.WriteLine($"Средняя температура: {average:°C 2}");
//Console.WriteLine($"Самая высокая температура: {maxTemp}");
//Console.WriteLine($"Самая низкая температура: {minTemp}");
//Console.WriteLine($"Дней ниже нуля: {belowZeroCount}");

//void PrintTemps(double[] temps)
//{
//    foreach (var temp in temps)
//    {
//        Console.Write($"{temp} ");
//    }
//    Console.WriteLine();
//}

//double CalculateAverage(double[] temps)
//{
//    if (temps.Length == 0) return 0;

//    double sum = 0;
//    foreach (var temp in temps) sum += temp;
//    return sum / temps.Length;
//}

//double FindMax(double[] temps)
//{
//    if (temps.Length == 0) return 0;

//    double max = temps[0];
//    foreach (var temp in temps)
//    {
//        if (temp > max) max = temp;
//    }
//    return max;
//}

//double FindMin(double[] temps)
//{
//    if (temps.Length == 0) return 0;

//    double min = temps[0];
//    foreach (var temp in temps)
//    {
//        if (temp < min) min = temp;
//    }
//    return min;
//}

//int CountBelowZero(double[] temps)
//{
//    int count = 0;
//    foreach (var temp in temps)
//    {
//        if (temp < 0) count++;
//    }
//    return count;
//}
//
//Console.ReadLine();

//=========================================================================================================================================================================================

//int[] shelf = new int[10];
//Random rand = new Random();

//for (int i = 0; i < shelf.Length; i++)
//{
//    shelf[i] = rand.Next(1, 8);
//}

//Console.WriteLine("--- Полка в понедельник ---");
//Console.Write("Текущие сроки: ");
//for (int i = 0; i < shelf.Length; i++)
//{
//    if (shelf[i] <= 0) Console.Write("[СПИСАН]");
//    else Console.Write(shelf[i]);

//    if (i < shelf.Length - 1) Console.Write(", ");
//}
//Console.WriteLine();

//Console.WriteLine("\n...Прошло 3 дня...\n");

//for (int day = 0; day < 3; day++)
//{
//    for (int i = 0; i < shelf.Length; i++)
//    {
//        shelf[i]--;
//    }
//}

//Console.WriteLine("--- Полка в четверг ---");
//Console.Write("Текущие сроки: ");
//for (int i = 0; i < shelf.Length; i++)
//{
//    if (shelf[i] <= 0) Console.Write("[СПИСАН]");
//    else Console.Write(shelf[i]);

//    if (i < shelf.Length - 1) Console.Write(", ");
//}
//Console.WriteLine();

//int expiredCount = 0;
//int freshestIndex = -1;
//int maxDays = 0;

//for (int i = 0; i < shelf.Length; i++)
//{
//    if (shelf[i] <= 0)
//    {
//        expiredCount++;
//    }
//    else if (shelf[i] > maxDays)
//    {
//        maxDays = shelf[i];
//        freshestIndex = i;
//    }
//}

//Console.WriteLine($"\nСписано товаров: {expiredCount} шт.");
//if (freshestIndex != -1)
//{
//    Console.WriteLine($"Позиция самого свежего йогурта на полке (индекс): {freshestIndex}");
//}
//else
//{
//    Console.WriteLine("На полке не осталось свежих йогуртов.");
//}

//Console.ReadLine();
