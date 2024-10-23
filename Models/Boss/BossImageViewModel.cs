namespace TetrisTARpe23.Models.Character
{
	public class BossImageViewModel
	{
		public Guid ImageID { get; set; }
		public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        public string Image { get; set; }
        public Guid? BossID { get; set; }
    }
}