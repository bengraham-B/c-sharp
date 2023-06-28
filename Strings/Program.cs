using System;

class Program
{
    static void Main(){

        Console.WriteLine("Ben \nGraham" + "\n Sammy");

        // Convert to Upper case
        string phrase = "Sammuel Sold guns to Algerin gangsters";
        Console.WriteLine(phrase.ToLower());
        Console.WriteLine(phrase.ToUpper());

        // Contains method
        Console.WriteLine(phrase.Contains("guns"));
        Console.WriteLine(phrase.Contains("Goose"));

        Console.WriteLine(phrase[0]);
        
        Console.WriteLine("Added From VS code 22:53");


        Console.WriteLine("");

    }
}
