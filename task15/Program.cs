// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
Console.Clear();
int dayOfWeek = new Random().Next(1,8);
Console.WriteLine($"Порядковый номер дня недели: {dayOfWeek}");
if (dayOfWeek != 6 && dayOfWeek != 7)
{
    Console.WriteLine("Это будний день недели");
}
else
{
    Console.WriteLine("Это выходной");
}