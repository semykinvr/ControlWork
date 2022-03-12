// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//**Примеры * *:
//["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] -> ["-2"]
//["Russia", "Denmark", "Kazan"] -> []

// Основная программа:
string[] massiv = FillArray(); // заполнение массива
//Console.WriteLine("Исходный массив: ");
//PrintArray(massiv); // печать исходного массива
string[] newMassiv = NewArray(massiv); // преобразование в новый массив
Console.WriteLine("Новый массив: ");
PrintArray(newMassiv); // печать нового массива
Console.WriteLine("Конец програмы. Нажмите любую клавишу");
Console.ReadKey();

//МЕТОДЫ:

// функция преобразования из одного массива в другой массив
string[] NewArray(string[] array)
{
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = array[i];
        }
    }
    return newArray;
}

// функция заполнения строкового массива с клавиатуры
string[] FillArray()
{
    int i = 0;
    string[] array = new string[i];
    string? input = String.Empty;

    Console.WriteLine("Заполните строковый массив значениями, (для выхода введите '0'): ");
    while (input != "0")
    {
        i++;
        Console.Write($"Ведите значение {i}: ");
        input = Console.ReadLine();
        if (input == "0") break;
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = input;
    }
    return array;
}

// функция печати массива
void PrintArray(string[] array)
{
    if (array.Length != 0)
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i] + "  ");
        }
}
