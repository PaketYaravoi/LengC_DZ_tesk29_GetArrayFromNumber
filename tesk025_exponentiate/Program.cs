// Напишите программу которая принимает на вход два числа и (А и B) и возводит число А в натуральную степень В

// 1) ввод данных , число 1 и число 2 
// 2) метод которой будет возводить в степень
// 3) принт результат

Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень возвести число?:"); // ввод переменных 
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiate(int a, int b)    // метод возведения в степень
{
    int stepen = a;
    for(int i = 1; i < b; i++)
    {
        stepen = stepen * a;
    }
    return stepen;
}
Console.WriteLine($"Число {numberA} в степени {numberB} = {Exponentiate(numberA, numberB)}"); // принт результат
