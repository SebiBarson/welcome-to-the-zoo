namespace WelcomeToTheZoo.API.Contracts.Requests
{
    public class AnimalRequest
    {
        public string Name { get; set; }

        public string Species { get; set; }

        public string EatingHabit { get; set; }

        public int Legs { get; set; }

        public int ZooId { get; set; }
    }
}
