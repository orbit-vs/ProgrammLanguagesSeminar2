int number = new Random().Next(10, 100);

//int firstDigit = 78 / 10;

Console.WriteLine("Сгенерироавно число" + number);

int firstDigit = number / 10;
int secondDigit = number % 10;

int maxDigit = 0;

if(firstDigit > secondDigit)
   maxDigit = firstDigit;
else
   maxDigit = secondDigit;

Console.WriteLine("Наибольшая цифра в числе " + number + ": " + maxDigit);       

