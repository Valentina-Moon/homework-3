//Подсчитать сумму цифр в числе
Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine()?? "0");
int S = 0;
while (A > 0)
{

    S = S + A % 10;
    A = A / 10;

}
Console.WriteLine($"сумма числа равна {S}");
