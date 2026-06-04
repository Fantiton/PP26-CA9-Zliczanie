Random rand = new Random();

int[] array = new int[rand.Next(1, 100)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-50, 50);
}

int[] sorted = sort(array);

Console.WriteLine("Posortowana tablica: ");
for(int i = 0; i < sorted.Length; i++)
{
    Console.WriteLine(i + " - " + sorted[i]);
}



int[] sort(int[] inputArray)
{
    //Szukanie najwyższej i najniższej wartości w tablicy
    int highest = inputArray[0];
    int lowest = inputArray[0];
    for (int i = 1; i < inputArray.Length; i++)
    {
        if (inputArray[i] > highest) highest = inputArray[i];
        if (inputArray[i] < lowest) lowest = inputArray[i];
    }

    int k = highest - lowest + 1;

    //Tablica pomocnicza
    int[] countArray = new int[k];

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
        }
        else
        {
            countArray[i - lowest] = count + countArray[i - lowest - 1];
        }
    }

    //Tablica wynikowa
    int[] outputArray = new int[inputArray.Length];

    for(int i = 0; i < countArray[0]; i++)
    {
        outputArray[i] = 0 + lowest;
    }
    for (int i = 1; i < countArray.Length; i++)
    {
        for(int j = countArray[i - 1]; j < countArray[i]; j++)
        {
            outputArray[j] = i + lowest;
        }
    }

    return outputArray;
}