using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.core.Domain
{
    public enum CharacterFriendLvL
    {
        Stranger, Friend, Good_Friends, BestFriend, Homie_level
    }
    public enum AttackComments
    {
        Double, Tripple, Tetris
    }
    public enum CharacterHP
    {
        FullHP, AlmoastFullHP, HalfHP, LowHP, VeryLowHP, Dead
    }
    public class Character
    {
        public Guid ID { get; set; }
        public string CharacterName { get; set; }
        public int CharacterUsed { get; set; }
        public int CharacterFriendNextLevel { get; set; }
        public CharacterFriendLvL CharacterFriendLvL { get; set; }
        public AttackComments AttackComments { get; set; }
        public CharacterHP CharacterHP { get; set; }
    }
}
