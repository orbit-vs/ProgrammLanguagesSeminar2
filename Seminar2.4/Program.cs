Console.WriteLine("Введите первое число ");
int numOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Второе число ");
int numTwo = Convert.ToInt32(Console.ReadLine());

double sqrtNumOne = Math.Sqrt(numOne);
double sqrtNumTwo = Math.Sqrt(numTwo);

System.Console.WriteLine(sqrtNumOne == Math.Abs(numTwo)) || sqrtNumTwo == Math.Abs(numOne);