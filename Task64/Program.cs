// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

void PrintNaturalNumbers(int n)
    {
        if (n <= 0)
            return;

        Console.WriteLine(n);
        PrintNaturalNumbers(n - 1);
    }

int number = GetInfo("Введите значение N: ");
PrintNaturalNumbers(number);
