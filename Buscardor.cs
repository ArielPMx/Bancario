using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Buscardor
    {
       public CuentaSuperAhorro BuscardorSuper(int cuenta)
        {
            CuentaSuperAhorro resultado = new CuentaSuperAhorro();
            foreach (var item in Repositorio.Instancia.SuperAhorro)
            {
                if (cuenta == item.NumeroDeCuenta)
                {
                    resultado.NumeroDeCuenta = item.NumeroDeCuenta;
                    resultado.Balance = item.Balance;
                }

            }
            return resultado;
        }

     public   CuentaDeAhorro BuscardorAhorro(int cuenta)
        {
            CuentaDeAhorro resultado = new CuentaDeAhorro();
            foreach (var item in Repositorio.Instancia.Ahorro)
            {
                if(cuenta == item.NumeroDeCuenta)
                {
                    resultado.NumeroDeCuenta = item.NumeroDeCuenta;
                    resultado.Balance = item.Balance;
                }


            }
            return resultado;
        }
    }
}
