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


void main()
{
    Console.Clear();
    string input = StringsInput("Введите строки через пробел или запятую");
    string[] numArray = InputArray(input);
}

main();