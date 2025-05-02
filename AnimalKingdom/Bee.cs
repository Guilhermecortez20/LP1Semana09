namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return "Bzzzz!";
        }

        public int NumberOfWings => 4;
    }
}
