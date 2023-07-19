int GetQuantityEvenNum(int[] array)
{
    int evenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    return evenNum;
}

int[] GetRandomArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] array = GetRandomArray(4, 100, 1000);
Console.Write($"[{String.Join(", ",array)}] -> ");
Console.Write(GetQuantityEvenNum(array));