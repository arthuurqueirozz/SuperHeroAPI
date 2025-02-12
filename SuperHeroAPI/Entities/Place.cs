using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SuperHeroAPI.Entities
{
    public class Place
    {
        public int Id { get; set; }
        public string PlaceName { get; set; } = string.Empty;
        public bool IsReal { get; set; } = false;

        //[JsonIgnore]
        [NotMapped]
        public List<SuperHero>? SuperHeros { get; set; }
    }
}
