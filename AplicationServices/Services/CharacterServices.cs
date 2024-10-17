using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.core.Domain;
using Tetris.Core.ServiceInterface;
using Tetris.Data;

namespace Tetris.AplicationServices.Services
{
    public class CharacterServices : ICharacterServices
    {
        private readonly TetrisCharacterContext _context;
        // private readonly IFileServices _fileServices;

        public CharacterServices(TetrisCharacterContext context /*IFileServices fileServices*/)
        {
            _context = context;
            //_fileServices = fileServices
        }
        /// <summary>
        /// Get Details for one Character
        /// </summary>
        /// <param name="id">Id of character to show details of</param>
        /// <returns>resulting character</returns>
        public async Task<Character>DetailsAsync(Guid id)
        {
            var result = await _context.Characters
                .FirstOrDefaultAsync(x => x.ID == id);
            return result;
        }
    }
}
