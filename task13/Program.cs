// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string box = Console.ReadLine();
int num = int.Parse(box);
int numC = num;
if (box.Length < 3)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    for (int i = 0; i < box.Length - 3; i++)
    {
        numC = numC / 10;
    }
    numC = numC % 10;
    Console.WriteLine($"{num} -> {numC}");
}


