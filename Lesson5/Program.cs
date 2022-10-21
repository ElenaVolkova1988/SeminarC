// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
int [] CreateArray(int size) // Создание массива
{
    int [] array =new int [size];
    Console.WriteLine("Creating array: ");

    for( int i=0; i<size; i++)
    {
        Console.Write($"Input a {i+1} element of array: ");
        array [i]= Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Compite!");
    return array;
}
 void ShowArray (int []array) // Вывод на печать
 {
    for( int i=0; i< array.Length; i++)
    Console.Write(array[i]+ " ");

    Console.WriteLine();
 }

 int SumOfNegatives (int[ ]array)
 {
    int sum= 0;
    for( int i=0; i<array.Length; i++)
    {
        if(array[i]<0)
        sum+=array[i];
    }
    return sum;
 }
Console.Write ("Input a number of elements: ");
int size =Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(size);
int result = SumOfNegatives (myArray);
ShowArray(myArray);
Console.WriteLine("Sum of negativ elements is"+result);


/*// Напишите программу замена элементов массива-положительные заменить на соответс отрицатель(наоборот)
    int[] MinusPlus (int [] array)
{
    for (int i=0; i< array.Length; i++)
    {
        array [i]*=-1;
    }
    return array;
 }
    Console.Write ("Input a number of elements: ");
    int size =Convert.ToInt32(Console.ReadLine());
    int [] myArray = CreateArray(size);
    ShowArray(myArray);
    int [] result=MinusPlus (myArray);
    ShowArray(result);*/
    

 /*// задача 2. Программа, которая определяет присутствует ли заданное число в массиве
 bool FindNumArray ( int[] array, int num)
 {
    for (int i=0; i<array.Length; i++)
    {
            if (array[i]== num) return true;
    }
    return false;
 }

    Console.Write ("Input a number of elements: ");
    int size =Convert.ToInt32(Console.ReadLine());
    int [] myArray = CreateArray(size);
    ShowArray(myArray);
    Console.WriteLine("Input a number");
    int number= Convert.ToInt32(Console.ReadLine());
    bool result = FindNumArray (myArray,number);
    Console.WriteLine(FindNumArray(myArray,number));


 // Задача 3. Задать массив из 12 случайных чисел. Найти количество элементов массива, значение которых лежат в отрезке от 10 до 99
    int FindAccordance( int[] array, int min,int max)
    {
        int count=0;
        for ( int i=0; i<array.Length; i++)
        {
            if ( min<=array[i]&& array[i]<=max) count++;   
        }
        return count;
    }
    Console.Write ("Input a number of elements: ");
    int size =Convert.ToInt32(Console.ReadLine());
    int [] myArray = CreateArray(size);
    ShowArray(myArray);
    Console.WriteLine("Input max ");
    int max=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min ");
    int min=Convert.ToInt32(Console.ReadLine());
    int find=FindAccordance(myArray,min,max);
    Console.WriteLine(find);*/
    



