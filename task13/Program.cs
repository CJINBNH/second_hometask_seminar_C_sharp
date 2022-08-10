// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// сделал задачу методом перевода в строку, проблему минуса решил
Console.Clear();
Console.WriteLine("Введите любое число: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());
int positiveNumber = Math.Abs(anyNumber);
string toString = positiveNumber.ToString();
int stringLenght = toString.Length;
int index = 2;

if (stringLenght >= 3)
{
    int thirdValue = int.Parse(toString[index].ToString());
    Console.Write("Третья цифра в этом числе: ");
    Console.WriteLine(thirdValue);
}
else
{
    Console.WriteLine("В этом числе нет цифры под третьим порядковым номером");
}

// Решение через рандом не подходит
// Console.Clear();
// int number = new Random().Next(97,103);
// Console.WriteLine($"Вводимое число: {number}");
// int thirdNumber = number%10;
// if (thirdNumber >= 0 && number >= 100)
// {
//     Console.WriteLine(thirdNumber);
// }
// else
// {
//     Console.WriteLine("Третья цифра отсутствует");
// }

//решение с помощью массива, также не подходит, нужно представить решение с вводом числа из консоли

// int[] arrayNumbers = { 4, 1106, 23, 566549, 52, 258, 45, 9875, 5, 323 };
// int length = arrayNumbers.Length;
// int index = 0;

// while (index < length)
// {
//     string value = arrayNumbers[index].ToString();
//     int a = value.Length;
//     if (a >= 3)
//     {
//         int result = int.Parse(value[2].ToString());
//         Console.Write(" ");
//         Console.Write(result);
//     }
//     else if (a < 3)
//     {
//         Console.Write(" ");
//         Console.Write("Третья цифра отсутствует");
//     }
//     index++;
// }