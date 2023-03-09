// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа.

string StringsInput(string text)
{
    Console.Write($"{text}: ");
    string numbers = Console.ReadLine()!;
    return numbers;
}

string[] InputArray(string num)
{
    char[] separators = new char[] {',', ' '};
    string[] array = num.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int SearchSize(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count ++;
        
    }
    return count;
}

string[] ArraySorting (string[] array, int size)
{
    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) 
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void PrintResult(string[] inputArray, string[] finalArray)
{
    Console.WriteLine($"Вы ввели строки: {String.Join(", ", inputArray)}");
    Console.WriteLine($"Из них строки, длина которых меньше или равна 3 символа: {String.Join(", ", finalArray)}");
}

void main()
{
    Console.Clear();
    string input = StringsInput("Введите строки через пробел или запятую");
    string[] inputArray = InputArray(input);
    int finalArraySize = SearchSize(inputArray);
    string[] finalArray = ArraySorting(inputArray, finalArraySize);
    PrintResult(inputArray, finalArray);
}

main();