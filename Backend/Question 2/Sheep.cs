namespace Backend_Q2
{
    //SHEEP CLASS INHERITING ANIMAL CLASS
    public class Sheep : Animal
    {
        //REMOVED EAT METHOD (REDUNDANT CODE)

        public override string MakeNoise()
        {
            return "Baaah";
        }
    }
}