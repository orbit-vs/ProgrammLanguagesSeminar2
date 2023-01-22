//Напишите программу, которая выводит случайное трехзначнное число и удаляет вторую цифру этого числа
//456 - 46
//782 - 72
//918 - 98


int num = new Random().Next(10, 1000);

int thirdDigit = num / 100;

int firstDigit = num % 10;

int result = thirdDigit * 10 + firstDigit;

Console.WriteLine("Сгенерированно число " + num);

Console.WriteLine("После удаления второго разряда получилось число " + result);

