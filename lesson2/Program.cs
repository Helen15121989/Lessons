// Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.
// 78 -> 8; 12->2; 85->8

Random random = new Random();

int randomNumber = random.Next (1,100);
int lastDigit = randomNumber % 10;
int first =  randomNumber / 10 % 10;

Console.WriteLine (randomNumber);

if (lastDigit > first)
{
   Console.WriteLine (lastDigit);
}
else
{

    Console.WriteLine (first);

}



