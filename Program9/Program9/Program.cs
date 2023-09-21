Random Random = new Random();

int count1 = 0;
int count2 = 0;

for (int i = 0; i < 100; i++)
{
    if (Random.Next()%2 == 0)
    { count1++; }
    else
    { count2++; }
}

Console.WriteLine(count1);
Console.WriteLine(count2);  