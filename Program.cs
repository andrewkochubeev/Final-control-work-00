// Задача: Написать программу, которая из
// имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] InputStringArray(int size)
{
    
    string[] wordsArray= new string[size];
    Console.WriteLine("Вводите слова");
    for (int i = 0; i < size; i++)
    {
        wordsArray[i]=Console.ReadLine()!;
    }
    return wordsArray;
}

Console.Write("Введите количество слов в массиве: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string[] wordsArr = InputStringArray(sizeArr);