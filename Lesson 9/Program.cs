/*//  Запросить число N и вывести все числа от 1 до N в рекурсивном методе
void ShowNums(int n)
{
    if(n>1) ShowNums(n-1);

    Console.Write(n+ " ");
}
ShowNums(5);*/

/*// Примет на вход число и выведит сумму цифр
int SumOfDigit (int num)
{
    if(num!=0) return SumOfDigit(num/10)+ num%10;
    else return 0;
}
Console.WriteLine( SumOfDigit(12345));*/

/*// Программа, которая выводит все натуральные числа от М до Н
void PrintNums (int m, int n)
{
    if (m>n)
    {
        Console.Write(m +" ");
        PrintNums(m-1,n);   
    }
    if (n> m) 
    {
        PrintNums(m, n-1);
        Console.Write(n + " ");
    }
}
    int m =1;
    int n= 5;
    PrintNums(m,n);*/

// Принимает а и в и возводит а в  целую степень в.
double PowerAB(double a, double b)
{   if (b<0)return 1/a*PowerAB(a,b+1);
    if(b>0) return a*PowerAB(a,b-1);
    else return 1;
}
Console.WriteLine(PowerAB(2,-3));