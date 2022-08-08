Console.WriteLine ("Введите два целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
Console.WriteLine("Первое число больше, второе число меньше");
}
else if(a < b)
{
Console.WriteLine("Второе число больше, первое число меньше");
}