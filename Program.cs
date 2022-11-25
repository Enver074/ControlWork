Console.WriteLine("Введите элементы массива через запятую");
string[] StringArray = Console.ReadLine()!.Split(',');

string[] newStringArray = SelectString(StringArray);

string[] SelectString(string[] StringArray)
{
    int size = StringArray.Length;
    int newSize = 0;
    int k = 0;
    string[] newStringArray = new string[newSize];

    for (int i = 0; i < size; i++)
    {
        if (StringArray[i].Length <= 3)
        {
            newSize++;
            Array.Resize(ref newStringArray, newSize);
            newStringArray[k] = StringArray[i];
            k++;
        }
    }
     return newStringArray;
}