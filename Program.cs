
Console.WriteLine("Задача 25");
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int perem = a;

for (int i = 1; i < b; i++)
{
    perem = perem * a;
}
Console.WriteLine("A в степени B равно: " + perem);





Console.WriteLine("Задача 27");
Console.WriteLine("Введите число");
int v = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (v > 0)
{
    int num = v % 10;
    v = v / 10;
    sum = sum + num;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sum);