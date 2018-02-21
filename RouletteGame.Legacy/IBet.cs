﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.Legacy
{
    public interface IBet
    {
        string GetPlayerName();
        uint GetAmount();
        uint WonAmount(IField);

    }
}
