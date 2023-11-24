using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;

Console.WriteLine("Введіть число від 1 до 9: ");
int a = int.Parse(Console.ReadLine());
if (a > 0 && a < 10)
{
    switch (a)
    {
        case 1:
            Console.WriteLine("1 = один");
            break;
        case 2:
            Console.WriteLine("2 = два");
            break;
        case 3:
            Console.WriteLine("3 = три");
            break;
        case 4:
            Console.WriteLine("4 = чотири");
            break;
        case 5:
            Console.WriteLine("5 = п'ять");
            break;
        case 6:
            Console.WriteLine("6 = шість");
            break;
        case 7:
            Console.WriteLine("7 = сім");
            break;
        case 8:
            Console.WriteLine("8 = вісім");
            break;
        case 9:
            Console.WriteLine("9 = дев'ять");
            break;
    }
}
else
    Console.WriteLine("Помилка, спробуйте ще раз.");