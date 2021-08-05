using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Repositorio
    {
        public static Repositorio Instancia { get; } = new Repositorio();
        public List<CuentaDeAhorro> Ahorro { get; set; } = new List<CuentaDeAhorro>();
        public List<CuentaSuperAhorro> SuperAhorro { get; set; } = new List<CuentaSuperAhorro>();


        private Repositorio()
        {

        }
    }
}
