// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine() ?? "0");
while (A < N)
{
    int S = A * A * A;
    
    if (S%2 == 0)
    Console.WriteLine($"A = {A}, куб числа A заканчивающийся на четную цифру  = {S}");
    A++;
}




