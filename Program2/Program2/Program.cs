Int32 number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= 10; i++)
{
    if (number % i == 0) Console.WriteLine(i);
}