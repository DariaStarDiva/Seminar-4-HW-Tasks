// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

int count = 0;
int result = 1;

while ( count <= b-1)
{
    result = result *a;
    count++;
}
Console.WriteLine(result);