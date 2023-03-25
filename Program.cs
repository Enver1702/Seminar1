/*
Task 3.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
int max = 0;
int min = 0;
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
   max = num1;
   min = num2;
}
else 
{
    max = num2;
    min = num1;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
*/
/*
Task 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
int max =0;
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > max)
{
   max = num1;
}
if (num2 >max)
{
  max = num2;  
}

if (num3 > max)
{
   max = num3;
}
Console.WriteLine("max = " + max);
*/
/* 
Task 5.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int remove = num % 2 ;
if (remove == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/
/*
Task 6. : Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;

if(num > 1)
{
    while(evenNumber <= num)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
*/
/*Task 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.Clear();
Console.Write("Enter a three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("the second digit of this number -> "+stringNumber[1]);
*/
/*
Task 8: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 
*/
/*
Console.Write("Enter a number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("third digit -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> no third digit");
}
*/
/*
Task 9: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
Console.Write("Enter a number for the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("( выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7)
   {
    Console.WriteLine("это число ,а не день недели");
  }
  else 
  Console.WriteLine("( рабочий день) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);
*/
/* Task 10.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
/*
Console.Clear();
Console.Write("Enter a five-digit number: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"your number: {number} - palindrome.");
  }
  else 
  Console.WriteLine($"your number: {number} - not a palindrome.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else 
Console.WriteLine($"Enter the correct number");
*/
/* Task 11. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
int a1 = Coordinate("a", "1");
int b1 = Coordinate("b", "1");
int c1 = Coordinate("c", "1");
int a2 = Coordinate("a", "2");
int b2 = Coordinate("b", "2");
int c2 = Coordinate("c", "2");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Enter coordinate {coorName} points {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double a1, double a2, 
                double b1, double b2, 
                double c1, double c2)
                {
  return Math.Sqrt(Math.Pow((a2-a1), 2) + 
                   Math.Pow((b2-b1), 2) + 
                   Math.Pow((c2-c1), 2));
}

double segmentLength =  Math.Round (Decision(a1, a2, b1, b2, c1, c2), 2 );

Console.WriteLine($"Cut length  {segmentLength}"); 
*/
/* Task 12. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
Console.Write("Enter number: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
*/
/*
Task 13: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
/*
int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Enter the number A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter the number B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine($"Answer: " + exponentiation);
*/
/*
Task 14: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*
int num = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int num){
    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

int sumNumber = SumNumber(num);
Console.WriteLine($"The sum of the digits in a number: " + sumNumber);
*/
/*
Task 15: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
/*
Console.Write("Enter a series of numbers separated by a comma: ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  series)
{

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else 
        {
          Console.WriteLine($"Character input error. Enter numbers.");

      }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew)
{ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++)
  {
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length)
    {
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}
// функция  вывода массива на печать 
void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
   {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 
string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);
PrintArry(arrayOfNumbers);
*/
