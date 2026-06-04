Random rand = new Random();

int[] array = new int[rand.Next(1, 100)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-50, 50);
}



int[] sorted = sort([1, 1, 1, 2, 2, 4, 8, 3, 4, 2, 5, 6, 7, 8, 9]);
foreach (int num in sorted)
{
    Console.Write(num + " ");
}

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

    int[] outputArray = new int[inputArray.Length];

    Console.WriteLine("Liczba: " + (0 + lowest) + " do ideksu: " + countArray[0]);
    for(int i = 0; i < countArray[0]; i++)
    {
        outputArray[i] = 0 + lowest;
        Console.WriteLine($"|{i}| - |{0 + lowest}|");
    }

    for (int i = 1; i < countArray.Length; i++)
    {
        Console.WriteLine("Liczba: " + (i + lowest) + " od ideksu: " + countArray[i - 1]);

        for(int j = countArray[i - 1]; j < countArray[i]; j++)
        {
            outputArray[j] = i + lowest;
            Console.WriteLine($"|{j}| - |{i + lowest}|");
        }
    }

    return outputArray;
}