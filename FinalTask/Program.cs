void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] finalArray = { "Hello", "2", "World", ";-)" };
string[] emptyArray = new string[4];
