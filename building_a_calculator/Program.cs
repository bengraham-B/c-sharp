using System;

class Program
{
    static void Main(){

        string characterName = "Goerge";
        int characterAge = 70;

        Console.WriteLine("There was oncde a man named " + characterName); 
        Console.WriteLine("He was " + characterAge + " Years old"); 
        Console.WriteLine("He really liked the name " + characterName); 
        Console.WriteLine("He did not like being seventy " + characterAge); 
        
        characterName = "Mike";
        Console.WriteLine("He changed his name to " + characterName); 

        Console.ReadLine();
    }
}