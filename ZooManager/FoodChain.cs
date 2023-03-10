using System.Collections.Generic;

namespace ZooManager
{
    public class FoodChain
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
    }
}
