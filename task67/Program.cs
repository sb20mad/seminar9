// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.WriteLine("Введите N");
int number = Convert.ToInt32(Console.ReadLine());

int res = PrintSumNumbers(number);

Console.WriteLine(res);
int PrintSumNumbers(int n)
{
    if (n == 0) return 0;      
   return (n % 10 + PrintSumNumbers (n / 10));
}

