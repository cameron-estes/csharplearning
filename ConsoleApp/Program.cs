// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp;

class CharacterBuild {
    static void Main() {
        while(true) {
            Random random = new Random();
            Console.WriteLine("Make Your Character");

            Console.Write("Enter your character's name: ");
            string name = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter your character's race: ");
            string race = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter your character's class: ");
            string characterClass = Console.ReadLine() ?? "Unknown";


            Console.WriteLine("Generating stats...");
            System.Threading.Thread.Sleep(500);

            int strength = random.Next(1,101);
            int dexterity = random.Next(1,101);
            int intelligence = random.Next(1,101);
            int speed = random.Next(1,101);
            int constitution = random.Next(1,101);
            int wisdom = random.Next(1,101);
            int charisma = random.Next(1,101);

            Console.WriteLine($"Your character is a {race} {characterClass} named {name}.");
            Console.WriteLine($"Stats: \nStrength: {strength}\nDexterity: {dexterity}\nIntelligence: {intelligence}\nSpeed: {speed}\nConstitution: {constitution}\nWisdom: {wisdom}\nCharisma: {charisma}.");

            Console.WriteLine("\n");
        }
    }

}
