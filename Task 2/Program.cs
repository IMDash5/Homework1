Console.Write("Введите первое число: ");
string num1 = Console.ReadLine();
int number1 = int.Parse (num1); 

Console.Write("Введите второе число: ");
string num2 = Console.ReadLine();
int number2 = int.Parse (num2);

Console.Write("Введите третье число: ");
string num3 = Console.ReadLine();
int number3 = int.Parse (num3);

int max = 0;
int min = 0;

if (number1 > number2) 
{
    max = number1;
    min = number2;
}
else 
{
    max = number2;
    min = number1;
}
if (max < number3)
{
    max = number3;
}
else 
{
    if (min > number3)
    {
        min = number3;
    }
}
Console.WriteLine($"Максимальное число: {max}. Минимальное число: {min}.");
