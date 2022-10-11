/*
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
 int GetSum ( int a)
 {
    int sum =0;

    for(int current=1; current<=a; current++ )
        sum+=current;
    return sum;
 }
Console.WriteLine("Input");
int num = Convert.ToInt32(Console.ReadLine());
int s = GetSum(num);
Console.WriteLine($"Sum {s}");*/

/*// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
 int DigigtCount ( int a ) 
 {
    int count =0;
    while(a!=0)
    {
        a=a/10;
        count++;
    }
     return count;
 }
 Console.WriteLine("Input");
int num = Convert.ToInt32(Console.ReadLine());
int s = DigigtCount(num);
Console.WriteLine(s);*/

/*//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int Factorial (int a)
{
    int result=1;
    for(int count=1; count<=a; count++)
        result*=count;
    return result;
}
Console.WriteLine("Input");
int num = Convert.ToInt32(Console.ReadLine());
int s = Factorial(num);
Console.WriteLine(s);*/

//Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.Генерация массива
 int[] CreateRandomArray(int size, int minValue, int maxValue)// мин и мах это отрезок числел
 {
    int[] newArray= new int[size];

    for( int i=0; i<size;i++)
        newArray[i]=new Random().Next(minValue,maxValue+1);
    return newArray;
 }

 //  Вывод массива на печать
 void ShowArray ( int[]array)
 {
    for(int i=0; i< array.Length; i++)
    {
        Console.Write ( array[i] + " ");

    Console.WriteLine();
    }
 }

 Console.Write("Введите элементы");
 int size= Convert.ToInt32(Console.ReadLine());
 int min=0;
 int max=9;

 int[] myArray = CreateRandomArray (size, min, max);
 ShowArray(myArray);