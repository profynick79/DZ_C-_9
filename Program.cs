// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     // Базовый (условие выхода из рекурсии)
//     if (start == end) return end.ToString();// start.ToString() преобразует int start в строчку
//     //Рекурсивный
//     return (start + ", " + PrintNumbers(start - 1, end));
// }
// Console.WriteLine(PrintNumbers(number, 1));


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int start = M;
// int end = N;
// if (start < end) 
// {
//     start = N;
//     end = M; 
// }
// Console.WriteLine(SumNambers(end-1, start));

// int SumNambers(int start, int end)
// {
//     int res = start;
//     if (start == end)
//         return 0;
//     else
//     {
//         start++;
//         res = start + SumNambers(start, end);
//         return res;
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

// вызов функции Аккермана
Console.Write(GetAkkermanFunction(m, n)); 

// функция Аккермана
int GetAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return GetAkkermanFunction(m - 1, 1);
    }
    else
    {
        return (GetAkkermanFunction(m - 1, GetAkkermanFunction(m, n - 1)));
    }
}