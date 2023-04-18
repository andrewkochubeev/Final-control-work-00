// Задача: Написать программу, которая из
// имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] InputStringArray(int size)
{

    string[] wordsArray = new string[size];
    Console.WriteLine("Вводите слова");
    for (int i = 0; i < size; i++)
    {
        wordsArray[i] = Console.ReadLine()!;
    }
    return wordsArray;
}
string[] SelectedWordsArray(string[] wordsArray)
{
    int resultArraySize = 0;
    for (int i = 0; i < wordsArray.Length; i++)
    {
        if (wordsArray[i].Length <= 3) resultArraySize++;
    }
    string[] resultArray = new string[resultArraySize];
    int j = 0;
    for (int i = 0; i < wordsArray.Length; i++)
    {
        if (wordsArray[i].Length <= 3)
        {
            resultArray[j] = wordsArray[i];
            j++;
        }
    }
    return resultArray;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i < array.Length - 1 ? $"\"{array[i]}\", " : $"\"{array[i]}\"]");
    }
}

Console.Write("Введите количество слов в массиве: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string[] wordsArr = InputStringArray(sizeArr);
string[] resultArr = SelectedWordsArray(wordsArr);
if (resultArr.Length > 0) PrintArray(resultArr);
else Console.WriteLine("Результирующий массив пуст :(");