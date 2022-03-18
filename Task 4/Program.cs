Console.Write("Введите число: ");
string n = Console.ReadLine();
int N = int.Parse(n);

int i = 2;
while (i <= N)
{
    Console.WriteLine($"{i} ");
    i = i + 2;
}