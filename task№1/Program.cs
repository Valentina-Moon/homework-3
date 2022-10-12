// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine() ?? "0");
int A = 1;
while (A < N)
{
    int S = A * A * A;
    Console.WriteLine($"A = {A}, куб числа A = {S}");
    A++;
}