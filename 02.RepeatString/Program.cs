using System.Text;

string[] input = Console.ReadLine().Split();
StringBuilder result = new StringBuilder();

foreach (string word in input)
{
    int repeatCount = word.Length;
    for (int i = 0; i < repeatCount; i++)
    {
        result.Append(word);
    }
}

Console.WriteLine(result);