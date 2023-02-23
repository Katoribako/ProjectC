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