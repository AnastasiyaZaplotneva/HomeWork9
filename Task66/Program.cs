// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Введите первое натуральное число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int SummOfNaturalNumbers(int n, int m)
{
    if (n == m) return n;
    return n + SummOfNaturalNumbers(n + 1, m);
}

int result = default;
if(numberOne > numberTwo) 
{
    result = SummOfNaturalNumbers(numberTwo, numberOne);
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {numberOne} до {numberTwo} равна {result}");
}
else 
{
    result = SummOfNaturalNumbers(numberOne, numberTwo);
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {numberOne} до {numberTwo} равна {result}");
}
 