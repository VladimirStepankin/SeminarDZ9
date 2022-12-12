/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.*/

int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");
int Akkerman = FuncAkkerman(m, n);
Console.WriteLine($"A({m},{n}) = {Akkerman}");
int FuncAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if  ((n == 0) && (m > 0)) return FuncAkkerman(m - 1, 1);
    else  return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}