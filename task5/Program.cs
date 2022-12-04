// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46 782 -> 72 918 -> 98


Random random = new Random();

int randomNumber = random.Next (100,1000);

Console. WriteLine (randomNumber);
 
 int firstDigit = randomNumber/100; // узнаем первое число
 int lastDigit = randomNumber % 10; // узнаем последнее число
 int newDigit = firstDigit * 10 + lastDigit; // узнаем первое и второе число 

 Console. WriteLine (newDigit);


