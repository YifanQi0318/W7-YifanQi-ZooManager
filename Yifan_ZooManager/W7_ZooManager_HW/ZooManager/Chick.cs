using System;

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
            TurnCounter++;
            Console.WriteLine($"It's{species}'s turn {TurnCounter}");
        }

        public void ChickRun()
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

    }
}
