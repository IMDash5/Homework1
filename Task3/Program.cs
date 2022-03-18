Console.Write("Введите число: ");
string num = Console.ReadLine();
int number = int.Parse (num);

if (number % 2 == 0) Console.WriteLine("Число чётное");
else Console.WriteLine("Число нечётное");