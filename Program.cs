string[] array = new string[] { "Hello", "2", "world", ":-)" };// ["1234", "1567", "-2", "computer science"],["Russia", "Denmark", "Kazan"]
string[] newArray = new string[array.Length];

void FormingArrayOfThreeOrFewerSymbols(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);
FormingArrayOfThreeOrFewerSymbols(array, newArray);
PrintArray(newArray);