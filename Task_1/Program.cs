//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine() ?? " ");
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine() ?? " ");
int res = a;

for (int i = 1; i < b; i++)
{
    res = res * a;
}
Console.WriteLine("A в степени B равно: " + res);

