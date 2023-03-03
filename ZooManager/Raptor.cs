using System;

namespace ZooManager
{
    /*[[Summary]
     * a/ Develop a new subclass Raptor that hunts Cat en??es. The raptor should use the emoji 🦅 
and should have a reac?on ?me of 1. Where possible, avoid duplica?ng data or methods 
handled in other parts of the program. 
     * d/ Modify the Raptor so that it hunts both Cat and Mouse en??es (requires a) 
     * l/ Wherever you think appropriate, write a separate method that the Raptor can use to look for 
an empty Zone 2 squares away, regardless of whether the square between the Raptor and the 
empty square is occupied.  If such a square is found, the Raptor can "fly” to that square, 
ignoring any occupant of the square that is passes through. However, the Raptor will only do 
this if it does not find any prey (Mouse or Cat) in the adjacent square (Raptor priori?zes 
hun?ng over moving farther). This separate method should re-use other exis?ng methods as 
much as possible. 
     */
    public class Raptor : Bird
    {

        public Raptor(string name)
        {
            emoji = "🦅 ";
            species = "raptor";
            this.name = name;
            reactionTime = 1; // reaction time 1 
            TurnCounter= 0;
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a raptor, I can catch the sky.");
            Hunt();
            TurnCounter++;
            Console.WriteLine($"It's{species}'s turn {TurnCounter}");
            if (TurnCounter > 3)
            {
                Death(this);
            }
        }

        public void Hunt()//The raptor hunts for cat and mouse
        {
            if (Game.Seek(location.x, location.y, Direction.up, "cat"))
            {
                Game.Attack(this, Direction.up);
            }
            else if (Game.Seek(location.x, location.y, Direction.down, "cat"))
            {
                Game.Attack(this, Direction.down);
            }
            else if (Game.Seek(location.x, location.y, Direction.left, "cat"))
            {
                Game.Attack(this, Direction.left);
            }
            else if (Game.Seek(location.x, location.y, Direction.right, "cat"))
            {
                Game.Attack(this, Direction.right);
            }
            /*Let Raptor can catch the mouse*/
            else if (Game.Seek(location.x, location.y, Direction.up, "mouse"))
            {
                Game.Attack(this, Direction.up);
            }
            else if (Game.Seek(location.x, location.y, Direction.down, "mouse"))
            {
                Game.Attack(this, Direction.down);
            }
            else if (Game.Seek(location.x, location.y, Direction.left, "mouse"))
            {
                Game.Attack(this, Direction.left);
            }
            else if (Game.Seek(location.x, location.y, Direction.right, "mouse"))
            {
                Game.Attack(this, Direction.right);
            }
        }

        public void Death(Animal raptor)
        {
            int x = raptor.location.x;
            int y = raptor.location.y;

            Game.animalZones[location.y][location.x].occupant = new Skull("DeathBody");
        }


    }
}
