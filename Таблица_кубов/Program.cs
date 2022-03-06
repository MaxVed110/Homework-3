int number = new int();
double cube = new double();


Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица кубов: ");
for (int count = 1; count < number; count++)
{
    cube = Math.Pow(count, 3);
    Console.Write($"{cube}, ");
}
Console.Write($"{Math.Pow(number, 3)}.");
