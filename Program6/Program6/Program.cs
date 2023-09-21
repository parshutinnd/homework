Int16 number1 = 0;
Int16 number2 = 0;
int counter = 0;

number1 = Convert.ToInt16(Console.ReadLine());
number2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("---------------");

for (int i = number1; i <= number2; i++)
{
    if (i % 3 == 0 || i % 5 == 0 || i % 9 == 0)
    {
        Console.WriteLine(i + "\n");
        counter++;
    }
}
Console.WriteLine("Количество такиих чисел: " + counter);