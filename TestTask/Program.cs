string[] CreateRandomArray(int size)
{
    string[] Arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Please input {i + 1} (No empty!) string");
        Arr[i] = Console.ReadLine();
    }
    return Arr;
}

void ShowArray(string[] array)
{
    Console.Write(" In this array [ ");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + " | ");
    Console.Write($"{array[array.Length - 1]} ]");
    Console.WriteLine();
}