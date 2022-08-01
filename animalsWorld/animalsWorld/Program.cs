namespace methods
{
    public class animalsWorld
    {
        public animalsWorld()
        {
            Console.WriteLine("New animal produced...");
        }

        public String classification;
        private int numberOfLegs;
        public bool wing;

        public int NumberOfLegs
        {
            get
            {
                return numberOfLegs;
            }
            set
            {
                numberOfLegs = value;
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            animalsWorld human = new animalsWorld();
            human.classification = "Mammal";
            human.NumberOfLegs = 2;
            human.wing = false;

            animalsWorld cow = new animalsWorld();
            cow.classification = "Mammal";
            cow.NumberOfLegs = 4;
            cow.wing = false;


            animalsWorld flamingo = new animalsWorld();
            flamingo.classification = "Bird";
            flamingo.NumberOfLegs = 2;
            flamingo.wing = true;


            Console.WriteLine("classification of human: " + human.classification);
            Console.WriteLine("number of human's legs: " + human.NumberOfLegs);
            Console.WriteLine("human has wings. -> " + human.wing);
            Console.WriteLine("classification of cow: " + cow.classification);
            Console.WriteLine("number of cow's leg: " + cow.NumberOfLegs);
            Console.WriteLine("cow has wings. -> " + cow.wing);
            Console.WriteLine("classification of flamingo: " + flamingo.classification);
            Console.WriteLine("number of flamingo's legs: " + flamingo.NumberOfLegs);
            Console.WriteLine("flamingo has wings. -> " + flamingo.wing);
        }

    }
}