using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Core.Dto
{
 public enum CharacterFriendLvL
        {
            Stranger, Friend, Good_Friends, Best_Friend, Homie_Level
        }
        public enum AttackComments
        {
            Double, Tripple, Tetris
        }
        public enum CharacterHP
        {
            FullHP, AlmoastFullHP, HalfHP, LowHP, VeryLowHP, Dead
        }
    public class CharacterDto
    {
            public Guid ID { get; set; }
            public string CharacterName { get; set; }
            public int CharacterUsed { get; set; }
            public int CharacterFriendNextLevel { get; set; }
            public CharacterFriendLvL CharacterFriendLvL { get; set; }
            public AttackComments AttackComments { get; set; }
            public CharacterHP CharacterHP { get; set; }

        //image 
        /*
         public List<IFrimFile> Files { get; set; }
        public IEnumerable<FileDatabaseDto> Image { get; set; } = new List<FileToDatabaseDto>();
         */
    }
}
