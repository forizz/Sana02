using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
Console.WriteLine("Введіть число a: ");
var a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть число b: ");
var b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть число c: ");
var c = int.Parse(Console.ReadLine());

int D = b*b - 4*a*c;
double x1, x2;
if (D > 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2*a);
    x2 = (-b - Math.Sqrt(D)) / (2*a);
    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
}
else if (D == 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"x = {x1}");
}
else
{
    Console.WriteLine("Немає коренів");
}