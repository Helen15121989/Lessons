// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//              14 -> нет 46 -> нет 161 -> да


Random random = new Random();

int number = random.Next (10,100);
Console.WriteLine (number);

if ((number % 7==0) && (number % 23==0))
{
    Console. WriteLine ("Число кратно и 7, и 23");
}
else
{
    Console. WriteLine ("Число не кратно");
}
