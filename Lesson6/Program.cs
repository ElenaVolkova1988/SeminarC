// Выполнить разворот массива
int[] CreateRandomArray( )
 {
    Console.Write("Input a number of elements: ");
    int size= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max= Convert.ToInt32(Console.ReadLine());

    int[] newArray= new int[size];

    for( int i=0; i<size;i++)
        newArray[i]=new Random().Next(min,max+1);
    return newArray;
 }

void ShowArray ( int[]array)
 {
    for(int i=0; i< array.Length; i++)
    {
        Console.Write( $"{array[i] + " "}");

    Console.WriteLine();
    }
 }

/*void ReverdArray( int[] array)
{
    for(int i=0,last=array.Length-1;i<last;i++,last--)
    {
        int temp=array[i];
        array[i]=array[last];
        array[last]=temp;
    }   
}

int[] myArray = CreateRandomArray ();
ShowArray(myArray);
ReverdArray(myArray);
ShowArray(myArray);*/

// Которая пинимает 3 числа, проверяет  может ли существовать треугольник с такими сторонами
//каждая сторона треугольника сторого меньше суммы двух других

/*bool ExistanceTriagle( double a, double b, double c )
{
    if(a<b+c&&b<a+c&&c<a+b) return true;
    return false; 
}
Console.WriteLine("Введите строру а: ");
double sideA=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите строру b: ");
double sideB=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите строру c: ");
double sideC=Convert.ToDouble(Console.ReadLine());
bool res=ExistanceTriagle(sideA,sideB,sideC);
if (res) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");*/


// Копия массива поэлементному копированию
int[]CopyArray(int[]array)
{
    int[]copy =new int[array.Length];
    for( int i=0; i<array.Length;i++)
    {
        copy[i]=array[i];
    }
    return copy;
}
  int [] arrayTask2=CreateRandomArray( );
  ShowArray(arrayTask2);
   int[] copyArrTask2=CopyArray(arrayTask2);
  ShowArray(arrayTask2);

// Вывести первые два числа Фиббоначи 
/*int [] Fibonacci ( int n, int a, int b)
{
    int[] fibArray= new int [n];
    fibArray[0]= a;
    fibArray[1]=b;

    for (int i =0; i<fibArray.Length;i++)
    {
        fibArray[i]=fibArray[i-1]+fibArray[i-2];
    }
    return fibArray;
}
int[]arrTask3=Fibonacci(3,0,1);
ShowArray(arrTask3);*/
