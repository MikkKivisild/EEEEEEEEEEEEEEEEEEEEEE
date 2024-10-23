namespace TetrisTARpe23.Models.Character
{

    public enum BossHP
    {
        100, 200, 300, 400, 500, 600, 700, 800, 900, 1000
    }
    public class BossIndexViewModel
    {
        public Guid ID { get; set; }
        public string BossName { get; set; }
        public BossHP BossHP { get; set;}
    }
}