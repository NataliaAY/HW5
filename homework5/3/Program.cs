Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
float[] numbers = new float[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Искомый массив: ");
PrintArray(numbers);

float min = Int32.MaxValue;
float max = Int32.MinValue;
for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
    {
        max = numbers[x];
    }
    if (numbers[x] < min)
    {
        min = numbers[x];
    }
}
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");

Console.WriteLine($"Дельта между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(float[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = (new Random().Next(100,1000)) / 100;
    }
}
void PrintArray(float[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}