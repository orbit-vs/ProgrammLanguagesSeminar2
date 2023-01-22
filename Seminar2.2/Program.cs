Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;

if(number1 ==0 || number2 == 0)
   System.Console.WriteLine("Одно из чисел является нулем ");

if(result == 0)
   Console.WriteLine("Кратно");
else 
   Console.WriteLine("не кратно, остаток " + result);  