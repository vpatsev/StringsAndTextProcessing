﻿string input = Console.ReadLine();


while (input != "end") {
    string reversed = "";
    for (int i = input.Length - 1; i >= 0; i--)
    {

        reversed += input[i];

     
    }
    Console.WriteLine($"{input} = {reversed}");

    input = Console.ReadLine();
}


