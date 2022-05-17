using System.ComponentModel.DataAnnotations;

namespace WelcomeToTheZoo.API.Domain
{
    public class Zoo
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public float Acres { get; set; }

        public List<Animal> Animals { get; set; } 
    }
}
