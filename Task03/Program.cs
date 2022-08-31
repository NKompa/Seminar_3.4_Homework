// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19, 6, 1, 33  -> [1, 2, 5, 7, 19, 6, 1, 33]

int [] array = new int [8];

void FillArray (int [] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while(index<length)
    {
        numbers[index] = new Random().Next(1,35);
        index++;
    }
}
void PrintArray (int [] mass)
{
    int lenght = mass.Length;
    int index = 0;
    while(index<lenght)
    {
        Console.Write(mass[index]+" ");
        index++;
    }
}

FillArray(array);
PrintArray(array);