using System.ComponentModel.DataAnnotations;

namespace WelcomeToTheZoo.API.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
