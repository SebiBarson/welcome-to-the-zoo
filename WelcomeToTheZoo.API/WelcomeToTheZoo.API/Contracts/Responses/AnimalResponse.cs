namespace WelcomeToTheZoo.API.Contracts.Responses
{
    public class AnimalResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public string EatingHabit { get; set; }

        public int Legs { get; set; }

        public int ZooId { get; set; }
    }
}
