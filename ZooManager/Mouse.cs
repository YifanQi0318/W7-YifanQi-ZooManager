using System;
using System.Collections.Generic;

namespace ZooManager
{
    public class Mouse : Animal
    {
        public Mouse(string name)
        {
            emoji = "🐭";
            species = "mouse";
            this.name = name; // "this" to clarify instance vs. method parameter
            reactionTime = new Random().Next(1, 4); // reaction time of 1 (fast) to 3
            Predator = new List<string>() { "cat" };
            TurnCounter= 0;
            /* Note that Mouse reactionTime range is smaller than Cat reactionTime,
             * so mice are more likely to react to their surroundings faster than cats!
             */
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a mouse. Squeak.");
            Flee(Predator);
            TurnCounter++;
            Console.WriteLine($"It's{species}'s turn {TurnCounter}");
            if (TurnCounter > 3)
            {
                Death(this);
            }
        }

        /* Note that our mouse is (so far) a teeny bit more strategic than our cat.
         * The mouse looks for cats and tries to run in the opposite direction to
         * an empty spot, but if it finds that it can't go that way, it looks around
         * some more. However, the mouse currently still has a major weakness! He
         * will ONLY run in the OPPOSITE direction from a cat! The mouse won't (yet)
         * consider running to the side to escape! However, we have laid out a better
         * foundation here for intelligence, since we actually check whether our escape
         * was succcesful -- unlike our cats, who just assume they'll get their prey!
         */

        public void Death(Animal mouse)
        {
            int x = mouse.location.x;
            int y = mouse.location.y;

            Game.animalZones[location.y][location.x].occupant = new Skull("DeathBody");
        }
    }
}

