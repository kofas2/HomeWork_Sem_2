// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число любой разрядности: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
    {
        while (num >= 1000) 
        {
            num/=100;    
        }
        int secondDig = num % 10;
        Console.WriteLine($"\nТретьей цифрой заданого числа является {secondDig}");
    }   
else 
{
    Console.WriteLine("\nТретьей цифры нет :( ");
}