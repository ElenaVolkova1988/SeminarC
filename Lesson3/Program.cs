/*// Заданы точки в системе координат, нужно определить плоскость, в которой находится
 
int FindQuart(double x, double y) 
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The point A {x},{y} is on the {FindQuart(x,y)} quart");*/

/*// необходимо написать программу, которая по заданному номеру четверти покажет диапозон координат точек
void FindRenge(int quart) 
{
    if (quart==1)
    { 
        Console.WriteLine("x > 0 && y > 0");
    }
    if (quart==2) 
    {
        Console.WriteLine("x < 0 && y > 0");
    }
    if (quart==3)
    {
        Console.WriteLine ("x < 0 && y < 0");
    }
    if (quart==4) 
    {

        Console.WriteLine ("x > 0 && y < 0");
    }

}
    Console.Write("Input quart: ");
    int quart = Convert.ToInt32 (Console.ReadLine());
    FindRenge(quart);*/

/*// нахождение между двумя точками в двумерном пространстве

    double Distanc ( double xa, double ya, double xb, double yb)
    {
      return Math.Sqrt(Math.Pow((xb-xa),2)+ Math.Pow(( yb-ya),2));
    }
    Console.Write("Input xa-coordinate: ");
    double xa = Convert.ToDouble(Console.ReadLine());        
    Console.Write("Input ya-coordinate: ");
    double ya = Convert.ToDouble(Console.ReadLine());  
    Console.Write("Input yb-coordinate: ");
    double yb = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Input ya-coordinate: ");
    double xb = Convert.ToDouble(Console.ReadLine()); 
   Console.WriteLine(Distanc(xa,ya,yb,xb));*/

// написать программу, которая принимает на вход число N и выдает квадраты чисел от 1 до N

void WriteQ(int n) 
{
    int count =1;
    while (count<=n)
    {
        Console.WriteLine(Math.Pow(count,2));
        count++;
    }
}
 Console.WriteLine("Input N number: ");
 int n =Convert.ToInt32(Console.ReadLine());
 WriteQ(n);