/*Задача 66:Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.*/

int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
int summ = SumNumbers(m, n);
Console.WriteLine(summ);
int SumNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;
    else if (n == 0) return (m * (m + 1)) / 2;
    else if (m == n) return m;
    else if (m < n) return n + SumNumbers(m, n - 1);
    else return n + SumNumbers(m, n + 1);
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}