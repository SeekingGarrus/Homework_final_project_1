// Задание: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3-м символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

string[] NewArray(string[] array)
{
    string[] result = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintNewArray(string[] arr)
{
    Console.WriteLine("Изначальный массив:");
    PrintArray(arr);
    string[] shortArray = NewArray(arr);
    Console.WriteLine($"Новый массив, где длина символов равна, либо меньше 3-х: ");
    PrintArray(shortArray);
    Console.WriteLine();
}

string[] arrayText = { "-", "Я", "думаю", ",", "-", "сказал", "князь", ",", "улыбаясь", ",", "-", "что", ",",
            "ежели", "бы", "вас", "послали", "вместо", "нашего", "милого", "Винценгероде", ",",
            "вы", "бы", "взяли", "приступом", "согласие", "прусского", "короля", ".",
            "Вы", "так", "красноречивы", ".", "Вы", "дадите", "мне", "чаю", "?"};
PrintNewArray(arrayText);