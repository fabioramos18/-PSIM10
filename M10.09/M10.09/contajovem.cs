using System;
using System.Collections.Generic;
using System.Text;

namespace M10._09
{
 
        class contajovem : contapoupança
        {
            public double Depositox(double deposito)
            {
                return Saldo + (deposito * 0.0025) + deposito;
            }
        }
    }
}
}
