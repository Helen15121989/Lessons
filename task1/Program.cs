﻿// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет

int numberA = int.Parse(Console.ReadLine ());
int numberB= int.Parse(Console.ReadLine ());

if ((numberB * numberB) == numberA)
{
 Console.WriteLine ("Первое число является квадратом второго");
}
else

{
    Console.WriteLine ("Первое число не является квадратом второго");

}
