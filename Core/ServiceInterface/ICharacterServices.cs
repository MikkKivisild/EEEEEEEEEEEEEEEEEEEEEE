using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.core.Domain;

namespace Tetris.Core.ServiceInterface
{
    public interface ICharacterServices
    {
        Task<Character> DetailsAsync(Guid id);

    }
}
