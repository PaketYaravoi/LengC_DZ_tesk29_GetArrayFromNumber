// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19])
// 1) для начала напишем промпт с которого будем забирать значения
// 2) напишем метод для генерации случайного массива
// 3) метод для печати массива 
// 4) показать результат

int Prompt(string massage)  // метод для ввода из стрки сразу в число ! 
{
    System.Console.Write(massage); // выводим приглашение ко вводу 
    string stringEmpty = System.Console.ReadLine()!;
    int result = int.Parse(stringEmpty);
    return result;
}

int[] GetArray (int Length, int minValue, int maxValue) // Метод для генирации случайного массива 
{ 
    int[] array = new int [Length];                    // инициализируем массив, выделяем под него память
    Random rnd = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);  // заполняем его случайными числами от минимального значени до макс(аргументы надпомню вводим сами)
    }
    return array;
}

void PrintArray(int[] array)  // метод для печати нашего массива привильно и красиво!
{
    Console.Write("[");
    for(int i = 0; i < array.Length -1; i++) // почему до предпоследнего , потому как его мы не будем учитывать, а учтем после цикла, в строке он запишется как число 
                                             // после запятой и все, после него не будет ни каких доп символов
    {
        System.Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}"); // тут мы его добавляем после цикла, 
    Console.WriteLine("]");                     //  а тут закрываем скобко , все для кросаты
}
   
int length = Prompt("Введите число: "); // тут и так все ясно)
int min = Prompt("Введите число: ");
int max = Prompt("Введите число: ");
int[] trueArray = GetArray(length, min, max); // передаем аргументы нашей функции
PrintArray(trueArray);   // Печатаем массив

