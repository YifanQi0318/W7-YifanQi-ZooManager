using System;
using System.Collections.Generic;

namespace ZooManager
{/*Goal #3: Create an Alien class that:

is not extending base class Animal (it is its own "top level" class, unless you have created another class "above" Animal)
only implements Predator, not Prey Interface
can attack everything (including Landscape items, if you are working from Class #8's starter code!)
has its own "add to board" button (you can choose the emoji this time!)
  */
    public class Alien: Apex
    {
        public Alien(string name)
        {
            emoji = "👽 ";
            species = "raptor";
            this.name = name;
            reactionTime = 1; // reaction time 1 
            Prey = new List<string>() { "cat", "mouse" ,"raptor","chick"};
            TurnCounter = 0;
        }
        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I ammmmm aaaaa aliennnnnnnnnnn.");
            Hunt(Prey);
            TurnCounter++;
            Console.WriteLine($"It's{species}'s turn {TurnCounter}");
           
        }
    }
}
