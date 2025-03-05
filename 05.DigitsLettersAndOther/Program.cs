﻿using System.Text;

string input = Console.ReadLine();

StringBuilder digits = new StringBuilder();
StringBuilder letters =  new StringBuilder();
StringBuilder characters = new StringBuilder();

foreach (char ch in input)
{
    if (char.IsDigit(ch))
    {
        digits.Append(ch);
    }
    else if (char.IsLetter(ch)) 
    { 
        letters.Append(ch);
    }  
    else
    {
        characters.Append(ch);
    }
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(characters);