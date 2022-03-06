int number = new int();
double rebmun = new double();
double number1 = new double();
double count = new double();


Console.Write("Введите число: ");

number = Convert.ToInt32(Console.ReadLine());
rebmun = number;
number1 = number;
count = 0;

while (rebmun > 0)
{

    rebmun = Math.Round(rebmun / 10, 0);
    count++;
}

while (count > 0)
{
    rebmun = rebmun + number % 10 * Math.Pow(10, count - 1);
    number = number / 10;
    count--;
}

if(number1 == rebmun)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}