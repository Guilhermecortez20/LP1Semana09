namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound()
        {
            return "Screech!";
        }

        public int NumberOfNipples => 2;
        public int NumberOfWings => 2;
    }
}
