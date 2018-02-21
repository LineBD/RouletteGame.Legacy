using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.Legacy
{
    public interface IField
    {
        uint Color();
        uint Number();
        bool Even();
    }
}
