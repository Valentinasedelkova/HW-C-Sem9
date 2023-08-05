// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int CalculateSum(int start, int end)
    {
        if (start == end)
            return start;
        else
            return start + CalculateSum(start + 1, end);
    }

int numberM = GetInfo("Введите значение M: ");
int numberN = GetInfo("Введите значение N: ");
int sum = CalculateSum(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов от {numberM} до {numberN} равна {sum}.");
