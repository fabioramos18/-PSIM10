fghusing System;
using System.Collections.Generic;
using System.Text;

namespace M10._09
{
    class contapoupança : conta
    {
        public double comissao()
        {
            return saldo * 0.99;
        }
    }
}