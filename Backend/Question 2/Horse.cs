namespace Backend_Q2
{
    //HORSE CLASS INHERITING ANIMAL CLASS
    public class Horse : Animal
    {
        //REMOVED EAT METHOD (REDUNDANT CODE)

        public override string MakeNoise()
        {
            return "Neigh";
        }
    }
}