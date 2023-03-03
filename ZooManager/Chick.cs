using System;
using System.Security.Cryptography.X509Certificates;

namespace ZooManager
{
    /*Summary
     c/ Make a second subclass of Bird (requires b) called Chick that flees from Cat entities. The 
        chick should use the emoji 🐥 and should have a reac?on ?me between 6 and 10.  (0.75）
     */
    public class Chick: Bird
    {
        public Chick(string name)
        {
            emoji = "🐥";
            species = "chick";
            this.name = name;
            reactionTime = new Random().Next(6, 10);
            TurnCounter= 0;
           
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a chick, cheep cheep");
            ChickRun();
            /*Found a bug, it seems that the chick detects the global variable TurnCounter instead of his own "maturity time",*/
            if (TurnCounter == 3)//Mature Method, use the turn counter to decide if it will change to raptor
            {
                Mature(this); //When turn arrived 3, call this function
            }
            else
            {
                TurnCounter++;
                Console.WriteLine($"It's{species}'s turn {TurnCounter}");
            }

        }

        public void ChickRun()//Chick's function
        {
            if (Game.Seek(location.x, location.y, Direction.up, "cat"))
            {
                if (Game.Retreat(this, Direction.down)) return;
            }
            if (Game.Seek(location.x, location.y, Direction.down, "cat"))
            {
                if (Game.Retreat(this, Direction.up)) return;
            }
            if (Game.Seek(location.x, location.y, Direction.left, "cat"))
            {
                if (Game.Retreat(this, Direction.right)) return;
            }
            if (Game.Seek(location.x, location.y, Direction.right, "cat"))
            {
                if (Game.Retreat(this, Direction.left)) return;
            }
        }

        /*[Summary]
         Add a new method Mature to class Chick (requires c). Aler a Chick has been on the board 
         for 3 turns – i.e., the ac?va?on when its turn counter would be incremented to 4 – (requires 
         feature m) replace that Chick with a new Raptor
         */
        public void Mature(Animal chick)
        {
            int x = chick.location.x;
            int y = chick.location.y;

            Game.animalZones[location.y][location.x].occupant = new Raptor("MaturedRaptor");//Use this function to generate a raptor replaced chick
        }



    }
}
