namespace AnimalKingdom
{
    public class Cat : Animal, IMammal
    {
        public override string Sound()
        {
            return "Meow!";
        }

        public int NumberOfNipples => 8;
    }
}
