﻿Main(); // Программа, которая выводит третью цифру числа или сообщает, что её нет!

void Main()
{
    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine()!);
    FindThirdInNum(n);

    void FindThirdInNum(int num)
    {
        if (num > 99 & num < 1000)
        {
            Console.WriteLine("Третья цифра числа " + num % 10);
        }
        else if (num > 1000)
        {
            Console.WriteLine("Слишком много цифр! Введите трёхзначное число.");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет! Введите трёхзначное число.");
        }
    }
}