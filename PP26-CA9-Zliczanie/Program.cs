Random rand = new Random();

int[] array = new int[rand.Next(1, 100)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-50, 50);
}

Console.WriteLine("Tablica:");
foreach (int num in array)
{
    Console.WriteLine(" " + num);
}
Console.WriteLine();