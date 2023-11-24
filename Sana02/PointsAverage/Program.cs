using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;

int sum = 0;

for (int i = 1; i < 6; i++)
{
    Console.WriteLine($"Введіть оцінку {i}: ");
    int a = int.Parse(Console.ReadLine());
    if (a < 0 && a > 100)
    {
        Console.WriteLine("Ви некоректно ввели оцінку");
        i--;
    }
    else
        sum += a;
}

int avarage = sum / 5;

Console.WriteLine($"Ваша середня оцінка: {avarage}");

if (avarage >= 50)
    Console.WriteLine("Ви допущені до екзамену");
else
    Console.WriteLine("Ви не допущені до екзамену");