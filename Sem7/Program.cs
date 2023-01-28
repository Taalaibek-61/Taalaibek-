/*int[,] GreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
     Console.Write("input a number of columss: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min passible Value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("input a max  passible Value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,colums];
    for( int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums;j++)
        array[i,j] = new Random().Next(minValue,maxValue);
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = GreateRandom2dArray();
Show2dArray(myArray);*/



/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
/*int[,] CreateRandom2dArray() 
{ 
    Console.Write("Input a number of rows: "); 
    int rows= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a number of columns: "); 
    int columns= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a min possible value: "); 
    int minValue= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a max possible value: "); 
    int maxValue= Convert.ToInt32(Console.ReadLine()); 


    int[,] array = new int[rows, columns]; // Выделение памяти для двумерного массива 

    for(int i=0; i < rows; i++) 
        for(int j=0; j < columns; j++) 
            array[i,j] = new Random().Next(minValue, maxValue + 1);  

    return array; 
} 

void Show2dArray(int[,] array) 
{ 
    for(int i =0; i < array.GetLength(0); i++ ) 
    { 
        for(int j=0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + " "); 
        } 
    Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 


double[] MethodD(int[,] array) 
{
    double[]aver = new double[array. GetLength(1)];

  
      for(int j=0; j < array.GetLength(1);j++) 
       
      { 
        for(int i=0; i < array.GetLength(0);i++)
            aver[j] += array[i,j];
         aver[j] = Math.Round((aver[j] / array.GetLength(0)),2);
      } 
      return aver;
}

void ShowArray (double[] aver)

{
for(int i=0; i < aver.GetLength(0);i++)
    Console.Write(aver[i]+ " ");
Console.WriteLine(); 
} 

int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 
double[]myAver = MethodD(myArray);
Console.WriteLine("Среднее арифметическое значение каждого столбца"); 
 ShowArray (myAver);*/

 
/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
 значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> числа с такими индексами в массиве нет*/

/*int[,] CreateRandom2dArray() 
{ 
    Console.Write("Input a number of rows: "); 
    int rows= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a number of columns: "); 
    int columns= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a min possible value: "); 
    int minValue= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a max possible value: "); 
    int maxValue= Convert.ToInt32(Console.ReadLine()); 


    int[,] array = new int[rows, columns]; // Выделение памяти для двумерного массива 

    for(int i=0; i < rows; i++) 
        for(int j=0; j < columns; j++) 
            array[i,j] = new Random().Next(minValue, maxValue + 1);  

    return array; 
} 

void Show2dArray(int[,] array) 
{ 
    for(int i =0; i < array.GetLength(0); i++ ) 
    { 
        for(int j=0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + " "); 
        } 
    Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 


void MethodF(int[,] array) 
{
    Console.WriteLine("Введите номер столбца: ");
    int k = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите номер строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int m = 0;
    //int k = 0;
    //int n = 0;
    
    for(int i=0; i < array.GetLength(0);i++) 

      { 
        for(int j=0; j < array.GetLength(1); j++)
        {
           if( k >= 0 && k <= array. GetLength(0) &&
              n >= 0 && n <= array.GetLength(1)) 
           {
           m = array[k,n];
          
           } 
           else 
           {
            Console.WriteLine("По данному координату элементов нет");
           }
           
        }
      }
       Console.WriteLine("По данному координату находиться элемент:" + m);
       

int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 
  
 MethodF(myArray);*/ 
  /*Задача 47. Задайте двумерный массив размером m×n, заполненный
 случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
double [,] GreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min passlble value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max passlble value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double [rows, colums];
         for(int i = 0; i < rows; i++)
         {
            for(int j = 0; j < colums; j++)
                array[i,j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()),2);
         }
    return array;
}    
void Show2dArray(double[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");
            
         Console.WriteLine();
    }
    Console.WriteLine();
}
 
double[,] myArray = GreateRandom2dArray();
 Show2dArray(myArray);