/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
Console.WriteLine("Enter the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Here is our array: ");
PrintArray(num);
int count = 0;

for (int j = 0; j < num.Length; j++)
if (num[j] % 2 == 0)
count++;

Console.WriteLine($"Total {num.Length} numbers, {count} of them even");

void FillArrayRandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0  
*/
/*
int size = 5;
int[] num = new int[size];
FillArrayRandomNumbers(num);
PrintArray(num);

int sumNumbersEvenIndex = 0;

for (int i = 1; i < num.Length; i += 2)
{
    sumNumbersEvenIndex += num[i];
}
Console.Write(sumNumbersEvenIndex);



void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
/*
int size = 7;
int[] num = new int[size];
FillArrayRandomNumbers(num);
PrintArray(num);

int max = num[0];
int min = num[0];

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > max)
    {
        max = num[i];
    }
    else if (num[i] < min)
    {
        min = num[i];
    }
}

Console.WriteLine($"Minimum number: {min}");
Console.WriteLine($"Maximum number: {max}");
Console.WriteLine($"Difference between maximum and minimum numbers: {max-min}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/