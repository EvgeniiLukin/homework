//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] CreateRadomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1); // +1 - чтобы вошел верхний предел
    
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int ShowEvenOfNumbers( int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
        {
            current ++;
        } 
    return current;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRadomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine($"Колличество четных чисел в массиве - {ShowEvenOfNumbers(myArray)}");*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] CreateRadomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1); 
    
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumOfElements( int[] array)
{
    int current = 0;
    for(int i = 1; i < array.Length; i = i +2)
        current += array[i];
    return current;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRadomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {SumOfElements(myArray)}");*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1 ) + new Random().NextDouble();
        array[i] = Math.Round(array[i], 3);
    }
    return array;
}
void ShowArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void DifMaxMinNumbers (double [] array)
{
    double max = array[0];
    double min = array[0];
    double difNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
        if(min > array[i]) min = array[i];
    }
    difNum = max - min;
    difNum = Math.Round(difNum, 3);
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} числами: {difNum}");
}
Console.Write("input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(size,min,max);
ShowArray(myArray);
DifMaxMinNumbers(myArray);
*/
