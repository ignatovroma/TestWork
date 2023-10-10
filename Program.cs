// string[] PromtArray(string message)
// {
//     Console.Clear();
//     Console.Write(message);
//     string[] promt = Console.ReadLine().Split(' ');
//     return promt;
// }

// int Promt(string message)
// {
//     Console.Clear();
//     Console.Write(message);
//     var value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     Console.Clear();
//     return result;
// }

// int ArrayElementCouter(string[] inputArr, int elLength)
// {
//     int count = 0;
//     for (int i = 0; i < inputArr.Length; i++)
//     {
//         inputArr[i] = inputArr[i].Trim('"');
//         if (inputArr[i].Length <= elLength) count++;
//     }
//     return count;
// }

// string[] inputArray = PromtArray("Введите элементы массива через пробел: ");
// int elementLength = Promt("Введите количество знаков элементов нового массива: ");
// int count = ArrayElementCouter(inputArray, elementLength);

// string[] NewArray(int count, int elLength)
// {
//     string[] outputArray = new string[count];
//     int index = 0;
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         if (inputArray[i].Length <= elLength)
//         {
//             outputArray[index] = inputArray[i];
//             index++;
//         }
//     }
//     return outputArray;
// }

// string[] printArray = NewArray(count, elementLength);
// // Console.Write("Исходный массив: ");
// // for (int i = 0; i < inputArray.Length; i++)
// // {       
// //     Console.Write(inputArray[i] + " ");    
// // }
// Console.WriteLine();
// Console.Write("Новый массив:    ");
// for (int i = 0; i < printArray.Length; i++)
// {       
//     Console.Write('\u0022' + printArray[i] + '\u0022' + " ");    
// }

static string[] PromtArray(string message)
{
    Console.Clear();
    Console.Write(message);
    string[] promtArray = Console.ReadLine().Split(' ');
    Console.Clear();
    Console.Write("Исходный массив: ");
    foreach (string arr in promtArray)
    {
        Console.Write(arr + " ");
    }
    Console.WriteLine();
    return promtArray;
}

string[] inputArray = PromtArray("Введите элементы массива через пробел: ");

string[] OutputArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            inputArray[count] = inputArray[i];
            count++;
        }
    }
    Array.Resize(ref inputArray, count);
    return inputArray;
}

OutputArray(inputArray);

Console.Write("Новый массив:    ");
foreach (string arr in inputArray)
{
    Console.Write(arr + " ");
}

Console.ReadKey();