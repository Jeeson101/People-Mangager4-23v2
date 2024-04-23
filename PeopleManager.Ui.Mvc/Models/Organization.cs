using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PeopleManager.Ui.Mvc.Models
{
    public class Organization
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public string? Description { get; set; }

        //Optional
        public IList<Person> Members { get; set; } = new List<Person>();

    }
}
