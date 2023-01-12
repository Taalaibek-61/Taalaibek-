/*Напишите программу, которая принимает на вход число (А) и выдаёт
 сумму чисел от 1 до А.*/




/*int GetSum(int num)
{
    int sum = 0;
    for(int current = 1; current <= num; current++)
     sum =+ current; // sum = sum = current;
     return sum;
    
}

Console.Write("Input a number");
int a = Convert.ToInt32(Console.ReadLine());

int resalt = GetSum(a);
Console.Write(resalt));*/

int[] GreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

     for(int i = 0; i < size; i++)
       array[i] = new Random().Next(minValue, maxValue + 1);
       return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length;i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.WriteLine("Input a number of elements:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min passible value:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max passible value:  ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = GreatRandomArray(m, min, max);
ShowArray(newArray);