/*
Console.WriteLine("Input a first number");
int n1= Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Input a second number");
int n2= Convert.ToInt32 (Console.ReadLine ());

int quad2 =n2*n2;

if (n1== quad2)
{
     Console.WriteLine ("Yes");
}
else
{
    Console.WriteLine ("No");
}
*/
/*Console.WriteLine ("Input a number:");
int number = Convert.ToInt32 (Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}*/
 
 /*253 % 10 -> 3
 253 % 100 -> 53
 253 % 1000 -> 253

 253 / 10 -> 25
 253 / 100 -> 2
 253 / 1000 -> 0
 */

 Console.Write ("Input three-digit number :");
 int n = Convert.ToInt32 (Console.ReadLine());

 if (n/100>0)
 {
    int lastDigit = n%10;
    Console.WriteLine ($"Last digit of {n} is {lastDigit}");
 }
else 
{
    Console.WriteLine ("Uncorrent input!");
}
 