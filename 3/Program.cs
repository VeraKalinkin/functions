//Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        }
    return array;
}
int[] ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = temp;
}
    return array;
}

int number = new Random().Next(1, 10);
int[] array = new int[number];
array = CreateArray(array);
Console.WriteLine(string.Join("; ", array));
array = ReverseArray(array);
Console.WriteLine(string.Join("; ", array));