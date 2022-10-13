// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран./
int  [] array = new int [8];

Console.WriteLine("Введите 8 чисел: ");
for (int i = 0; i < array.Length; i++)
array[i] = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"[{string.Join(", ", array)}]");


