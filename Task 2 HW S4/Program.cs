// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
/*
int size = Convert.ToString(n).Length;
for ( int i = 0; i < size; i++)
{
    result = result + n%10;
     n = n/10;
}
Console.WriteLine(result);
*/
while ( n > 9)
{     
     result = result + n%10;
     n = n/10;             
}
if (n<=9)
 result = result + n;
Console.WriteLine(result);

