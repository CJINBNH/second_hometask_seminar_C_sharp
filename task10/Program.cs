//Напишите программу,
//которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine($"Наше трехзначное число: {number}");
int result = number%100 / 10;
Console.WriteLine(result);

//решение через конвертирование в строку

string text = number.ToString();
int middle = int.Parse(text[1].ToString());
Console.WriteLine($"{middle}");
