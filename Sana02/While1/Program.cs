using System.Diagnostics.CodeAnalysis;
using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
Console.WriteLine("Введіть число n: ");
int n = int.Parse(Console.ReadLine());

double a = 0;
double b = 0;
double c = 1;

for (int i = 1; i <= n; i++) { 
    a += (Math.Pow(-1, n)) / (2 * n + 1);
}

for (int i = 1; i <= n; i++)
{
    b += 1 + (1.0/(i*i));
}

double sum = 0;
for (int i = 1; i <= n; i++)
{
    c *= i;
    sum += c;
}
Console.WriteLine($"a = {a}, b = {b}, c = {sum} ");