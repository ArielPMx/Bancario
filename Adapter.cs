using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Adapter : IBanco
    {
        CuentaSuperAhorro Super = new CuentaSuperAhorro();
        public void Apertura()
        {
            Super.Apertura();
        }

        public void consulta()
        {
           Super.consulta();
        }

        public void Depositos()
        {
             Super.Depositos();
        }

        public void Retiros()
        {
            Super.Retiro();
        }


    }
}
