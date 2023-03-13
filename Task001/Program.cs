// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1000 && num > 99)
    {
        while (num >= 100) 
        {
            num/=10;    
        }
        var secondDig = num % 10;
        Console.WriteLine(secondDig);
    }   
else 
{
    Console.WriteLine("Число не трёхзначное :( ");
}