namespace ZooManager
{/*Goal #3: Create an Alien class that:

is not extending base class Animal (it is its own "top level" class, unless you have created another class "above" Animal)
only implements Predator, not Prey Interface
can attack everything (including Landscape items, if you are working from Class #8's starter code!)
has its own "add to board" button (you can choose the emoji this time!)
  */
    public class Alien:Bird
    {
        public Alien(string name)
        {
            emoji = "👽 ";
            species = "raptor";
            this.name = name;
            reactionTime = 1; // reaction time 1 
            TurnCounter = 0;
        }
    }
}
