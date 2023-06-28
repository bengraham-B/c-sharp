using System;

class Program
{
    static void Main(){
        string phrase = "Samuel Sold guns to Algerian gangsters";

        Console.WriteLine("Ben \nGraham" + "\n Sammy");

        // Convert to Upper case
        Console.WriteLine(phrase.ToLower());
        Console.WriteLine(phrase.ToUpper());

        // Contains method
        Console.WriteLine(phrase.Contains("guns"));
        Console.WriteLine(phrase.Contains("Goose"));

        //Index
        Console.WriteLine(phrase[0]);
        
        //Contains
        Console.WriteLine(phrase.IndexOf("e"));

        //Substrings - grab a part of the string, index where you want to start grabbing the string at
        Console.WriteLine(phrase.Substring(8, 2));

        Console.WriteLine("");

    }
}
