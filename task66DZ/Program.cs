// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30 

Console.WriteLine("Введите начало M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите окончание n");
int numN = Convert.ToInt32(Console.ReadLine());


// if (numM > numN)
// Console.WriteLine("Введена не корректная последовательность");
int podmena = numM;
if (numM > numN) 
{
  numM = numN; 
  numN = podmena;
}
sumNumber(numM, numN, podmena=0);

void sumNumber(int m, int n, int sum)
{
    sum = sum + n;
     if (n <= m)
    {
    Console.Write($"Сумма --> {sum} ");
    return;
  }
  sumNumber(m, n - 1, sum);
}

