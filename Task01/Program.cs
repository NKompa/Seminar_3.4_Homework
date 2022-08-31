// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16.

Console.WriteLine("Введите число А: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

double result = 1;

Console.Write("Результат: ");

// double result = Math.Pow(numA,numB);
// Console.WriteLine(result);

for (int i = 0; i < numB; i++)
{
    result*=numA;
}
Console.WriteLine(result);