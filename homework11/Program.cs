﻿// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите два числа");

int numberA = int.Parse(Console.ReadLine ());
int numberB = int.Parse(Console.ReadLine ());

if (numberA > numberB)

{
    Console.WriteLine ("Максимально число: {0}", numberA);
}

if (numberB > numberA)

{
    Console.WriteLine ("Максимальное число {0}", numberB);
}

if (numberA == numberB)

{
    Console.WriteLine ("Числа равны");

}

