string[] PromtArray(string message)
{
    Console.Clear();
    Console.Write(message);
    string[] promtArray = Console.ReadLine().Split(' ');
    Console.Clear();
    return promtArray;
}

string[] inputArray = PromtArray("Введите элементы массива через пробел: ");

string[] OutputArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref array, count);
    return array;
}

void PrintArray(string message, string[] array)
{
    Console.Write(message);
    Console.WriteLine(string.Join(" || ", array));
    // Console.Write(message + " ");
    // foreach (string arr in array)
    // {
    //     Console.Write(arr + " ");
    // }
    // Console.WriteLine();
}

PrintArray("Исходный массив: ", inputArray);
PrintArray("Новый массив:    ", OutputArray(inputArray));

Console.ReadKey();