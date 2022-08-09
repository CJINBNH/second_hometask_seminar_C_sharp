// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
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