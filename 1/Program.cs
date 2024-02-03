//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int FindSum(int sum, int number)
{
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

while (true)
{
    Console.WriteLine("Введите целое число: ");
    var text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }
    else
    {
        int number;
        if (int.TryParse(text, out number))
        {
            int sum = 0;
            sum = FindSum(sum, number);
            if (sum % 2 == 0)
            {
                break;
            }
        }
    }
}
