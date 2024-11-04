string[] fruitBakset = { "Apples", "Bananas", "Oranges" };
string[] pets = { "Cats", "Dogs", "Fish", "Hamasters" };
string[] characters = {"Harry", "Ron" };

PrintArrayElements(fruitBakset);
PrintArrayElements(pets);

static void PrintArrayElements(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i+1}. {someArray[i]}");
    }
}