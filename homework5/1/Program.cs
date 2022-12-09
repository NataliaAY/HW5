Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("искомый массив: ");
PrintArray(numbers);

int count = 0;
for (int x = 0; x < numbers.Length; x++)
if (numbers[x] % 2 == 0)
count++;
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
     Console.Write("[ ");
     for(int i = 0; i < numbers.Length; i++)
    {
         Console.Write(numbers[i] + " ");
    }
Console.Write("]");
Console.WriteLine();
}