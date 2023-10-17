using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

Random rnd = new Random();

while (true)
{
    Console.WriteLine("1. Игра \"Угадай число\" ");
    Console.WriteLine("2. таблица умножения");
    Console.WriteLine("3. Вывод делителей числа ");
    Console.WriteLine("4. Выход из программы");
    Console.Write("Введите действие: ");
    int choose = Convert.ToInt32(Console.ReadLine());

    if (choose == 1)
    {
        pepe();

    }
    if (choose == 2)
    {
        pep();

    }
    if (choose == 3)
    {
        popka();

    }
    if (choose == 4)
    {
        Console.WriteLine("Пока :(");
        break;
    }
}
static void pepe()
{
    Random rnd = new Random();
    int rand_chislo = rnd.Next(1, 100);
    int i = 0;
    while (true)
    {

        i += 1;
        Console.Write($"Попытка {i}, Введи число: ");

        int answ = Convert.ToInt32(Console.ReadLine());

        if (answ > rand_chislo)
        {
            Console.WriteLine("Меньше");
        }
        else if (answ < rand_chislo)
        {
            Console.WriteLine("Больше");
        }
        else
        {
            Console.WriteLine("пабеда! ");
            break;
        }
    }
}
static void pep()
{
    int[,] umnzh = new int[10, 10];
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            umnzh[i, j] = (i + 1) * (j + 1); ;
            Console.Write($"{umnzh[i, j]} \t");
        }
        Console.WriteLine();
    }
}
static void popka()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}


