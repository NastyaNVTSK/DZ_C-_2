
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int revNum = 0;
int temp2;
while (num > 0)
{
    temp2 = num % 10;
    revNum = revNum * 10 + temp2;
    num = num / 10;
}
if (revNum == temp)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}