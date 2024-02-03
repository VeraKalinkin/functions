//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        }
    return array;
}
int CountEven (int[] array, int count)
{
    for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count += 1;
    }
}
    return count;
}

int number = new Random().Next(1, 10);
int[] array = new int[number];
int count = 0;
array = CreateArray(array);
Console.WriteLine(String.Join(", ", array));
count = CountEven(array, count);
Console.WriteLine(count);