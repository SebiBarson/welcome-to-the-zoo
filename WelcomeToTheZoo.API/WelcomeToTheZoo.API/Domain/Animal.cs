using System.ComponentModel.DataAnnotations;

namespace WelcomeToTheZoo.API.Domain
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public string EatingHabit { get; set; }

        public int Legs { get; set; }

        public int ZooId { get; set; }

        public Zoo Zoo { get; set; }
    }
}
