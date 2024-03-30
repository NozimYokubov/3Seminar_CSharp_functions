// Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, 
// сумма цифр которого чётная.

// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]


while (true)
{
    string StopWord = "q";
    string OutputText = "Введите целое число, или введите q для выхода";
    Console.WriteLine(OutputText);
    string n = Console.ReadLine();
    if (n == StopWord)
    {
        Console.WriteLine("STOP");
        break;
    }
    else
    {
        int value = Convert.ToInt32(n);
        if (IsSumOfDigitsEven(value))
        {
            Console.WriteLine("STOP");
            break;
        }
    }

    bool IsSumOfDigitsEven(int num)
    {
        int i = 0;
        while (num > 0) 
        { 
            i +=num % 10;
            num /= 10; 
        }
        return i % 2 == 0;
    }
}
