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

sort([1, 1, 1, 2, 2, 4, 8, 3, 4, 2, 5, 6, 7, 8, 9]);

int[] sort(int[] inputArray)
{
    int highest = inputArray[0];
    int lowest = inputArray[0];
    for (int i = 1; i < inputArray.Length; i++)
    {
        if (inputArray[i] > highest) highest = inputArray[i];
        if (inputArray[i] < lowest) lowest = inputArray[i];
    }

    int k = highest - lowest + 1;

    int[] countArray = new int[k];

    Console.WriteLine($"|ix| - |nb| - |ct|");
    for (int i = lowest; i < highest; i++)
    {
        int count = 0;

        for (int j = 0; j < inputArray.Length; j++)
        {
            if (inputArray[j] == i) count++;
        }

        if (i == lowest)
        {
            countArray[0] = count;
            Console.WriteLine($"|{i - lowest}| - |{i}| - |{count}|");
        }
        else
        {
            countArray[i - lowest] = count + countArray[i - lowest - 1];
            Console.WriteLine($"|{i - lowest}| - |{i}| - |{count + countArray[i - lowest - 1]}|");
        }
    }

    return [1, 2];
}