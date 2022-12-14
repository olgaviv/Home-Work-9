// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if (n> 1) 
    ShowNumbers (n -1);
    
}
Console.WriteLine("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);
*/

//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int m, int n)
        {
            if (m == n) return m;                       // Если M=N
            else if (m < n) return n + SumNumbers(m, n - 1); // Если M<N
            else return n + SumNumbers(m, n + 1);            // Если M>N
        }
        
            Console.WriteLine("Input a number M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Результат суммы чисел S = {SumNumbers(m, n)}");
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akkerman (int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}

            Console.WriteLine("Input a positive number M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a positive number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Akkerman(m,n));