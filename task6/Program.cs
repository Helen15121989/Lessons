// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли первое число кратным второму. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно


Random random = new Random();

int firstNumber = random.Next (10,100);
int secondNumber = random.Next (1,10); 

Console. WriteLine (firstNumber);
Console. WriteLine (secondNumber);

int newDigit = (firstNumber % secondNumber);

if ((firstNumber % secondNumber) !=0)

{
    Console. WriteLine (newDigit);
}
else 
{
    Console.WriteLine ("Число кратно");
}
