using System;
namespace My_Awesome_Programm
{
    class Programm
    {
        static void Main(string[] args)
        {
            //Erscheinungsbild der Console anpassen(Farbe, Größe,...)
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowHeight = 30;
            //Gesprächsaufbau
            //print ausgabe einer frage(zb.)
            Console.WriteLine("Hello what's your name?");
            //eingabe zb. name ermöglichen
            Console.ReadLine();
            //print ausgabe nach eingabe
            Console.WriteLine("My name is Tom Riddle.\nI want to suck out your soul! ");
            Console.WriteLine("What is your favourite color?");
            //erneute eingabe
            Console.ReadLine();
            // erneute ausgabe...;)
            Console.WriteLine("Cool my is Bloodred");

            StoryTime(); 

        }
        
        static void StoryTime(){

            Console.Title = "The adventure begins!";
            Console.WindowHeight =30;

            Console.WriteLine ("Hello what's your name?");
            Console.ReadLine();
            Console.WriteLine("My name is Prof. Hyazinthe.");
            Console.WriteLine("Today you can choose your first Pokemon!");
            Console.WriteLine("Are you excitetd?");
            Console.ReadLine();
            Console.WriteLine("I feel you! ");
            Console.WriteLine("Which one of these 3 Pokeballs do you want to choose");
            
         
            Console.WriteLine("1 with Bulbasaur, the Incredible!");
            Console.WriteLine("2 with Bulbasaur, the Great!");
            Console.WriteLine("3 with Bulbasaur, the Awesome!");
            Console.WriteLine("Choose whisely");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Great Choice, here is your first Bulbasaur!");
            Console.ReadKey();
        }
    }
}
