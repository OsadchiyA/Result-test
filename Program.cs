//Метод создания массива строк
string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

//Метод вывода элементов массива
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Метод создания нового массива из элементов заданной длины
string[] ChangesArray(string[] array, int lengthElement)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthElement)
            size++;
    }
    if (size > 0)
    {
        string[] changesArray = new string[size];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= lengthElement)
            {
                changesArray[index] = array[i];
                index++;
            }
        }
        return changesArray;
    }
    else
    {
        string[] changesArray = new string[]
        {
            "В заданном массиве нет элементов, которые удовлетворяют условию"
        };
        return changesArray;
    }
}

Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
string[] arrayUser = CreateArray(size);
Console.WriteLine("Введите максимальную длину элемента массива массива");
int lengthElement = int.Parse(Console.ReadLine());
string[] arrayСhanges = ChangesArray(arrayUser, lengthElement);
Console.WriteLine();
ShowArray(arrayUser);
Console.WriteLine();
Console.WriteLine();
ShowArray(arrayСhanges);
