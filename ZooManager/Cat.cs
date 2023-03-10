using System;
using System.Collections.Generic;

namespace ZooManager
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            emoji = "🐱";
            species = "cat";
            Predator = new List<string>() 
            {
                "raptor"
            };
            Prey = new List<string>()
            {
                "mouse",
                "chick"
            };
            this.name = name;
            reactionTime = new Random().Next(1, 6); // reaction time 1 (fast) to 5 (medium)
            TurnCounter= 0;
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a cat. Meow.");
            Flee(Predator);
            Hunt(Prey);
            TurnCounter++;
            Console.WriteLine($"It's{species}'s turn {TurnCounter}");
            if ( TurnCounter > 3 )
            {
                Death(this);
            }
        }

        /* Note that our cat is currently not very clever about its hunting.
         * It will always try to attack "up" and will only seek "down" if there
         * is no mouse above it. This does not affect the cat's effectiveness
         * very much, since the overall logic here is "look around for a mouse and
         * attack the first one you see." This logic might be less sound once the
         * cat also has a predator to avoid, since the cat may not want to run in
         * to a square that sets it up to be attacked!
         */


        /*[Summary]
         * e/ Modify the Cat so that it hunts both Mouse and Chick entites and avoids Raptor en??es 
         (requires c) and priori?zes avoiding over hun?ng 
         */


       

        public void Death(Animal cat)
        {
            int x = cat.location.x;
            int y = cat.location.y;

            Game.animalZones[location.y][location.x].occupant = new Skull("DeathBody");
        }
    }
}

