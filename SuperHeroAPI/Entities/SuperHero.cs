namespace SuperHeroAPI.Entities
{
    public class SuperHero
    {
        public int Id { get; set; }
        public required string name { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        

        public int? SuitId { get; set; }
        public Suit? Suit { get; set; }

        public Place? PlaceOfAction { get; set; }
    }
}
