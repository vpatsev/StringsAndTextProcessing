﻿string textToRemove = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(textToRemove))
{
    int startIndex = text.IndexOf(textToRemove);  
    
    text = text.Remove(startIndex, textToRemove.Length);
}
Console.WriteLine(text);