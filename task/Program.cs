// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

Console.WriteLine("Введите первый элемент массива: ");
string firstElement = Console.ReadLine();

Console.WriteLine("Введите второй элемент массива: ");
string secondElement = Console.ReadLine();

Console.WriteLine("Введите третий элемент массива: ");
string thirdElement = Console.ReadLine();

Console.WriteLine("Введите четвертый элемент массива: ");
string fourthElement = Console.ReadLine();

Console.WriteLine("Введите пятый элемент массива: ");
string fifthElement = Console.ReadLine();


string[] array = new string[] { firstElement, secondElement, thirdElement, fourthElement, fifthElement};
PrintArray(array);
Console.Write(" -> ");
string[] resultArray = CreateResultArray(array);
PrintArray(resultArray);

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int CountOfElementWithThreeSymbols(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] CreateResultArray(string[] arr)
{
    int resultArrElIndex = 0;
    int resultArrLenght = CountOfElementWithThreeSymbols(arr);
    string[] resultArr = new string[resultArrLenght];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            {
                resultArr[resultArrElIndex] = arr[i];
                resultArrElIndex++;
            }
    }
    return resultArr;
}