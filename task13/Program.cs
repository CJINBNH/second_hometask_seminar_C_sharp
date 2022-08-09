// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Clear();
int number = new Random().Next(97,103);
Console.WriteLine($"Вводимое число: {number}");
int thirdNumber = number%10;
if (thirdNumber >= 0 && number >= 100)
{
    Console.WriteLine(thirdNumber);
}
else
{
    Console.WriteLine("Третья цифра отсутствует");
}

// // решение с помощью массива

int[] arrayNumbers = { 4, 1106, 23, 566549, 52, 258, 45, 9875, 5, 323 };
int length = arrayNumbers.Length;
int index = 0;

while (index < length)
{
    string value = arrayNumbers[index].ToString();
    int a = value.Length;
    if (a >= 3)
    {
        int result = int.Parse(value[2].ToString());
        Console.Write(" ");
        Console.Write(result);
    }
    else if (a < 3)
    {
        Console.Write(" ");
        Console.Write("Третья цифра отсутствует");
    }
    index++;
}