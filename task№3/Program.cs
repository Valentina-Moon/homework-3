// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N:");
int N =  int.Parse(Console.ReadLine() ?? "0");
int P = 1;
int i; 
for (i = 1; i <= N; i++)
{ 
            P = P* i;
} 
Console.WriteLine($"произведение чисел равно {P}"); 
