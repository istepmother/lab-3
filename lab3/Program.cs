using lab3;

var myDictionary = new StringsDictionary();
int counter = 0;
string[] lines = File.ReadAllLines("C:/Users/Elisa/RiderProjects/lab3/lab3/dictionary.txt");
foreach (var line in lines)
{
    counter++;
    var wordDefArray = line.Split(";");
    string word = wordDefArray[0];
    string definition = string.Join("", wordDefArray, 1, wordDefArray.Length - 1);
    myDictionary.Add(word, definition);
}
Console.WriteLine("hello! this is dictionary! amazing, isn't it? you can type in some word, and I will give you a definition");
while (true)
{
    string input = Console.ReadLine();
    string requestedWord = input.ToUpper();
    try
    {
        string defenition = myDictionary.Get(requestedWord);
        Console.WriteLine($"{requestedWord}   {defenition}");
    }
    catch
    {
        Console.WriteLine("there's no such word in our dictionary");
    }
}