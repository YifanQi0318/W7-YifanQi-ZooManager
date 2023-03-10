using System;
using System.Collections.Generic;

namespace ZooManager
{

    interface Predator
    {
        List<string> Prey { get; }
        void Hunt(List<string> Prey);
    }

    interface Prey
    {
        List<string> predators { get; }
        void Flee(List<string> Predator);
    }

    public class Animal
    {
        public string emoji;
        public string species;
        public string name;
        public int reactionTime = 5; // default reaction time for animals (1 - 10)
        public int TurnCounter;//Turn taken
        public List<string> Prey;
        public List<string> predators;
        public Point location;




        public void ReportLocation()//Find animal's location
        {
            Console.WriteLine($"I am at {location.x},{location.y}");
        }

        virtual public void Activate()//Activate animals
        {
            Console.WriteLine($"Animal {name} at {location.x},{location.y} activated");
        }

        public void Hunt(List<string> Prey)//Use listed preys to hunt
        {
            foreach (string prey in Prey)//Check every preys in list
            {
                if (Game.Seek(location.x, location.y, Direction.up, prey))
                {
                    Game.Attack(this, Direction.up);
                }
                else if (Game.Seek(location.x, location.y, Direction.down, prey))
                {
                    Game.Attack(this, Direction.down);
                }
                else if (Game.Seek(location.x, location.y, Direction.left, prey))
                {
                    Game.Attack(this, Direction.left);
                }
                else if (Game.Seek(location.x, location.y, Direction.right, prey))
                {
                    Game.Attack(this, Direction.right);
                }
            }
        }

        public void Flee(List<string> Predator)//Use listed predators to catch
        {
            foreach (string predator in Predator)//Check every predators in list
            {
                if (Game.Seek(location.x, location.y, Direction.up, predator))
                {
                    if (Game.Retreat(this, Direction.down)) return;
                }
                if (Game.Seek(location.x, location.y, Direction.down, predator))
                {
                    if (Game.Retreat(this, Direction.up)) return;
                }
                if (Game.Seek(location.x, location.y, Direction.left, predator))
                {
                    if (Game.Retreat(this, Direction.right)) return;
                }
                if (Game.Seek(location.x, location.y, Direction.right, predator))
                {
                    if (Game.Retreat(this, Direction.left)) return;
                }
            }
        }


    }     
}
