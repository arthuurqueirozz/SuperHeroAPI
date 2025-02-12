namespace SuperHeroAPI.Entities
{
    public class Suit
    {
        public int Id { get; set; }
        public string SuitName { get; set; }
        public bool IsTechnological { get; set; } = false;

        public int HeroId { get; set; }
    }
}
