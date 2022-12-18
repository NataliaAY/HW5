void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write("{0}", arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine("]");
}
void FillArray(int[] arrayToFill, int diviation)
{
    for (int i = 0; i < arrayToFill.Length; i++)
        arrayToFill[i] = new Random().Next(-diviation, diviation + 1);
}
void CopyArray(int[] arrayToCopy, int[] arrayToFill)
{
    for (int i = 0; i < arrayToCopy.Length; i++)
        arrayToFill[i] = arrayToCopy[i];
}
int arraySize = 0;
arraySize = new Random().Next(5, 20);
int[] firstArray = new int[arraySize];
int[] secondArray = new int[arraySize];
FillArray(firstArray, 20);
CopyArray(firstArray, secondArray);
Console.WriteLine("Искомый массив:");
PrintArray(firstArray);
Console.WriteLine("Копия искомого массива:");
PrintArray(secondArray);
Console.ResetColor();
