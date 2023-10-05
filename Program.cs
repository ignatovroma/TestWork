string[] PromtArray(string message)
{
    Console.Clear();
    Console.Write(message);
    string[] promt = Console.ReadLine().Split(' ');
    Console.Clear();
    return promt;
}

int Promt(string message)
{
    Console.Clear();
    Console.Write(message);
    var value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    Console.Clear();
    return result;
}

string[] inputArray = PromtArray("Введите элементы массива через пробел: ");
int elementLength = Promt("Введите количество знаков элементов нового массива: ");