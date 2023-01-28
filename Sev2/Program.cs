int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNumber = new Random().Next(100,1000);
Console.WriteLine("Current random three-digit number is" + randNumber);

int newNumber = CutNumber(randNumber);
Console.WriteLine("New version of number is" + newNumber);


./*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Павел Гуляев: Напишите программу, которая будет принимать на вход два числа и определять, является ли второе число кратным первому.

Павел Гуляев: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/
