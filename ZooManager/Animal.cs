using System;
namespace ZooManager
{
    //Part2: Modify ZooManager
    public class Animal
    {
        public string emoji;
        public string species;
        public string name;
        public int reactionTime = 5; // default reaction time for animals (1 - 10)
        public int TurnCounter;//Turn taken

        public Point location;

        public void ReportLocation()//Find animal's location
        {
            Console.WriteLine($"I am at {location.x},{location.y}");
        }

        virtual public void Activate()//Activate animals
        {
            Console.WriteLine($"Animal {name} at {location.x},{location.y} activated");
        }

    }     
}
