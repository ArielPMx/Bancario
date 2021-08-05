using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    interface IBanco
    {
        void Apertura();
        void Depositos();
        void Retiros();
        void consulta();
        
    }
}
