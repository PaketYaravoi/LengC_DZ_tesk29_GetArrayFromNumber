// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// думаю имеет смылс перевернуть число в строку и разбить его на отдельные элементы и после чего сложить все элементы строки поочередно.

// 1) ввод данных  (на этот раз воспользуемся/ напишем метод для ввода данных )
// 2) конвертация данных
// 3) метод деления строки на отдельные части
// 4) метод сложения тех частей

int Prompt(string massage)
{
    System.Console.Write(massage); // выводим приглашение ко вводу
    string stringInput = System.Console.ReadLine()!;
    int result = int.Parse(stringInput);  // парсим в число
    return result;  // возвращаем число, теперь можно рабоать.. 
}


int GetSumDigitAsNumber(int number)
{
    int result = 0;
    while(number > 0)
    {
        result = result + number % 10;
        number = number / 10; 
    }
    return result;
}

int number = Prompt("Введите число: "); // обрати внимание рабоать с одной строкой проще чем с конвертом
//int number = Convert.ToInt32(Console.ReadLine()); // это посторинке, 
Console.WriteLine($"Сумма всех цифр числа {number} = {GetSumDigitAsNumber(number)}");