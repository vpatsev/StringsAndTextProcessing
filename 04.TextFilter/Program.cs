List<string> bannedWords = Console.ReadLine()
                            .Split(", ")
                            .ToList();

string text = Console.ReadLine();

foreach(string replaceWord in bannedWords)
{
    string asterix = new string('*',replaceWord.Length);

   text = text.Replace(replaceWord,asterix);
}
Console.WriteLine(text);