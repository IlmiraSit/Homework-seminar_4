// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int i;
int[] a = new int[8];
Console.WriteLine("Введите массив чисел: ");
for (i = 0; i < 8; i++)
{
    a[i] = int.Parse(Console.ReadLine()?? " ");
}
for (i = 0; i < 8; i++)
{
    Console.Write($"{a[i]} | " );
}


