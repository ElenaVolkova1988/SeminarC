/*
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int FindBiggestDigit (int num)
{
    int max;
    int ed = num % 10;
    int dec = num / 10;

    if (ed >dec)
        max =ed;
    else
        max =dec;
    return max;
}

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit (number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");*/


/*// 1.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int TowDigitNumber (int num) 
{
    int result;
    int ed = num % 10;
    int dec = num / 100;
    result = dec*10+ed;

    return result;

}
int number = new Random().Next(100,1000);
int towDigitNumber = TowDigitNumber (number);

Console.WriteLine("Number is "+ number);*/



//2.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b. a и b - инфо от пользователя(тоже int)

bool MultiPleNumber (int number, int a, int b )

{
    bool result;
    if ( number % a == 0 && number % b == 0)
    {
        result = true;
    }
    else {
        result = false;
    }   
    return result;
}
Console.WriteLine ("Input a number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input first divisor ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second divisor");
int b = Convert.ToInt32(Console.ReadLine());

bool res = MultiPleNumber ( number, a, b );
Console.WriteLine (res);

