void Task10()
{
    // Напишите программу, которая принимает на вход  трехзначное число и на выходе 
    // показывает вторую цифру этого числа

    Console.WriteLine("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int hundreds = number / 100;
    int ones = number % 10;
    int result = (number - hundreds * 100 - ones) / 10;
    Console.WriteLine($"Вторая цифра числа - {result}");
}

void Task13()
{
    // Напишите программу, которая с помощью деления выводит третью цифру  
    // заданного числа или сообщает, что третьей цифры нет

    int number = 326743297;
    while (number > 999)
    {
        number = number / 10;
    }
    if (number < 999 & number > 100)
    {
        number = number % 10;
        Console.WriteLine($"Третья цифра числа - {number}");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа отсутствует");
    }
}

void Task15()
{
    // Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
    // и проверяет, является ли этот день выходным

    Console.WriteLine("Введите номер дня недели: ");
    int numberA = Convert.ToInt32(Console.ReadLine());

    if(numberA == 1)  Console.WriteLine("Этот день выходным не является");  
    else if(numberA == 2) Console.WriteLine("Этот день выходным не является");  
    else if(numberA == 3) Console.WriteLine("Этот день выходным не является");  
    else if(numberA == 4) Console.WriteLine("Этот день выходным не является");  
    else if(numberA == 5) Console.WriteLine("Этот день выходным не является");  
    else if(numberA == 6 | numberA == 7) 
    {
        Console.WriteLine("Этот день является выходным"); 
    }
    else Console.WriteLine("Данные введены не верно");
}
    Console.Clear();
    //Task10();
    //Task13();
    //Task15();