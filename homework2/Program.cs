﻿// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int FindSecondNumber (int num)
{
    int sot = num / 10;
    int dec = sot % 10;
    return dec;
}
int randNumber = new Random().Next(10,1000);
int secondNum = FindSecondNumber(randNumber);
Console.WriteLine($"The second number {randNumber} is {secondNum}");
*/
/*
int FindSecondNumber (int num)
{
    int sot = num / 10;
    int dec = sot % 10;
    return dec;
}
Console.Write("imput three-digit number: ");
int number = Convert.ToInt32 (Console.ReadLine());
int secondNum = FindSecondNumber(number);
Console.WriteLine($"The second number {number} is {secondNum}");
*/

// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

/*
void FindThirdNumber(int num)
{
    if(num >= 100)
    {
        int current = num;
        int thirdNum = 0;
        while (current > 1000)
        {
            current = current / 10;
        }
        thirdNum = current % 10;
        Console.WriteLine($"The third digit {num} is {thirdNum}");
    }
    else
    {
        Console.WriteLine($"Number {num} dont have third digit");
    }
}
Console.Write("imput number: ");
int number = Convert.ToInt32 (Console.ReadLine());
FindThirdNumber(number);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void SearchDayOff (int day)
{
    if (day < 6)
        Console.WriteLine($"Day {day} is work day");
    else Console.WriteLine($"Day {day} is day off");
}
Console.Write("imput day number(from 1 and to 7): ");
int number = Convert.ToInt32 (Console.ReadLine());
SearchDayOff(number);
*/
