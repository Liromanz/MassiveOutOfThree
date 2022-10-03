Console.WriteLine("Введите размер массива");
int massAmount;
while (!int.TryParse(Console.ReadLine(), out massAmount))
{
    Console.WriteLine("Ошибка, введите снова");
}
string[] massWords = MakeMassive(massAmount);
string[] resultWords = SortMassive(massWords);

Console.WriteLine("Все слова, длина которых 3 или меньше символа");
foreach (var word in resultWords)
{
    Console.WriteLine(word);
}


string[] MakeMassive(int length)
{
    string[] massWords = new string[length];
    for (int i = 0; i < massWords.Length; i++)
    {
        Console.WriteLine($"Введите значение для {i + 1} элемента массива");
        massWords[i] = Console.ReadLine();
    }
    return massWords;
}

int GetAmountOfCorrectValues(string[] massive)
{
    int amount = 0;
    foreach (string word in massive)
    {
        if (word.Length <= 3)
        {
            amount++;
        }
    }
    return amount;
}

string[] SortMassive(string[] oldMass)
{
    int newLength = GetAmountOfCorrectValues(oldMass);
    string[] newMass = new string[newLength];

    for (int i = 0; i < newLength; i++)
    {
        newMass[i] = FindAWord(oldMass, newMass);
    }
    return newMass;
}

string FindAWord(string[] oldMass, string[] newMass)
{
    for (int j = 0; j < oldMass.Length; j++)
    {
        if (oldMass[j].Length <= 3 && !newMass.Contains(oldMass[j]))
        {
            return oldMass[j];
        }
    }
    return "";
}