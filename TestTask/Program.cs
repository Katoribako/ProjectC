string[] StingArrayGen(int size) //We create array with random sting parts
{
    string[] Arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Please input {i + 1} (No empty!) string");
        Arr[i] = Console.ReadLine();
        if (Arr[i].Length == 0)
        {
            return new[] {"Please input not empty string"};
            
        }
    }
    return Arr;
}
void ShowArray(string[] array) //Method for showing our array to user
{
    Console.Write(" [ ");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + " | ");
    Console.Write($"{array[array.Length - 1]} ]");
    Console.WriteLine();
}

string[] String3CharFilter(string[] array) //Method for 3char filtration in our array
{
    int Char3Counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) Char3Counter++;
    if (Char3Counter == array.Length) return array;
    else if (Char3Counter != 0)
    {
        string[] threeCharArray = new string[Char3Counter];
        for (int i = 0; i < array.Length; i++)
            if (array[i].Length <= 3)
            {
                threeCharArray[threeCharArray.Length - Char3Counter] = array[i];
                Char3Counter--;
            }
        return threeCharArray;
    }
    else return new[] { "we have no elements with equal 3 or less characters in this array" };
}
Console.WriteLine("Please input a length of array");
int size = Convert.ToInt32(Console.ReadLine());
string[] arr = StingArrayGen(size);
ShowArray(arr);
string[] array3char = String3CharFilter(arr);
ShowArray(array3char);