namespace ZooManager
{/*[Summary]
  * p/ Aler crea?ng feature m, add a trait to your predator animals (the Cat and Raptor but not 
the Mouse and Chick) that tracks how many turns since they last ate (successfully aJacked 
prey). If a predator goes more than 3 turns without ea?ng – i.e., when the predator begins its 
4th turn without ea?ng – the predator dies and is replaced with a skull (☠) that occupies the 
space (so another animal can’t go there) but otherwise does nothing. The skull can be moved 
like any other animal (by taking it in to the holding pen and pupng it back on the board in a 
new empty spot) but it can’t be destroyed or removed; once a skull is on the board, the player 
has one fewer space to work with. 
  */
    public class Skull: Animal
    {
        public Skull(string name)
        {
            emoji = "☠";
            species = "skull";
            this.name = name;
            reactionTime = 1; // reaction time 1 
            TurnCounter = 0;
        }


    }
}
