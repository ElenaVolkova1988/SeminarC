// задать массив m на n заполнееный случайными числами
int[,] CreateRandom2dArray()//Генерация массива
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows, columns];// выделение памяти под введенное пользователем кол-во строк и столбцов

    for(int i=0; i<rows;i++)
        for(int j=0; j<columns;j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
    return array;    
}

 void Show2dArray( int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}

//int[,] myArray=CreateRandom2dArray();
//Show2dArray(myArray);


/*// массив заполненный по формуле ij=i+j
int[,] CreateRandom2dArray()//Генерация массива
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
   

    int[,] array=new int[rows, columns];// выделение памяти под введенное пользователем кол-во строк и столбцов

    for(int i=0; i<rows;i++)
        for(int j=0; j<columns;j++)
            array[i,j] = i+j;
    return array;    
}

 void Show2dArray( int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}

int[,] myArray=CreateRandom2dArray();
Show2dArray(myArray);*/

/*// найти элементы, у которых оба индекса четные и заменить эти элементы на их квадраты
void Qard2dArray ( int [,] array)
{
    for(int i=0; i<array.GetLength(0);i+=2)
    {
        for(int j=0; j<array.GetLength(1); j+=2)
            array[i,j]= array[i,j]*array[i,j];

        Console.WriteLine();    
}
}
int[,] myArray=CreateRandom2dArray();
Show2dArray(myArray);
Qard2dArray(myArray);
Show2dArray(myArray);*/

// найти сумму элементов на главной диагонали

int SumInHead(int [,]array)
{
    int sum=0;
    for(int i=0, j=0; i<array.GetLength(0) && j<array.GetLength(1); j++, i++ )
    {
        sum = sum+array[i,j];
    }
    return sum;
}
 int[,] myArray=CreateRandom2dArray();
Show2dArray(myArray);
int res= SumInHead(myArray);
Console.WriteLine($"{res}");



