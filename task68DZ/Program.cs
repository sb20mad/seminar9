// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
Console.WriteLine("Введите начало m");
double m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите окончание n");
double n = Convert.ToInt32(Console.ReadLine());
double fAkk = Aker(m, n);

Console.Write($" Произведение функции Аккермана = {fAkk} ");

double Aker(double m, double n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Aker(m - 1, 1);
    else return Aker(m - 1, Aker(m, n - 1));
}
//2
// не считает больше n=5 m=3