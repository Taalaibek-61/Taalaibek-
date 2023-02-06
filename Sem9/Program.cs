/*Задача 64: Задайте значение N. Напишите программу, которая выведет
   все натуральные числа в промежутке от N до 1. Выполнить с помощью 
   
   рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*void ShowNums (int num)
 {
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
 }
 Console.WriteLine("Ввeдите число N :"  );
 int num = Convert.ToInt32(Console.ReadLine());
 ShowNums(num)*/;

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*int GetSum(int M,int N)
 {
 if(M < N ) return M + GetSum( M +1, N);
 else if(M > N) return (M  + GetSum(M - 1,N));
 else return M;

  }
  Console.WriteLine("Ввeдите первое число N :"  );
 int N = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Ввeдите второе число M :"  );
 int M = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Сумма натуральных чисел:" + GetSum( M, N));*/

/*Задача 68: Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Akkerman(int m, int n)
{
   if( m == 0 ) return n + 1;
   else if( m > 0 && n == 0) return Akkerman((m - 1), 1);
   else if( m >= 0 && n >= 0) return Akkerman((m - 1),Akkerman(m,n - 1)); 
   else return 0;

}
Console.WriteLine("Ввeдите первое число m :"  );
 int m = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Ввeдите второе число n :"  );
 int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Значение функции Аккермана " + Akkerman(m, n));


