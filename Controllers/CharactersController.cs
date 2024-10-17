using Microsoft.AspNetCore.Mvc;
using Tetris.Core.ServiceInterface;
using Tetris.Data;
using TetrisTARpe23.Models.Character;

namespace TetrisTARpe23.Controllers
{
    public class CharactersController : Controller
    {
        /*
         * Make Character comments
         */
        private readonly TetrisCharacterContext _context;
        private readonly ICharacterServices _characterServices;

        public CharactersController(TetrisCharacterContext context, ICharacterServices characterServices)
        {
            _context = context;
            _characterServices = characterServices;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var resultingInventory = _context.Characters
                .OrderByDescending(y => y.CharacterFriendLvL)
                .Select(x => new CharacterIndexModel
                {
                    ID = x.ID,
                    CharacterName = x.CharacterName,
                    CharacterUsed = x.CharacterUsed,
                    CharacterFriendNextLevel = x.CharacterFriendNextLevel,
                    CharacterFriendLvL = (CharacterFriendLvL)x.CharacterFriendLvL,
                });
                return View();
        }
    }
}
