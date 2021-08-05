using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class CuentaDeAhorro : IBanco
    {
        public int NumeroDeCuenta { get; set; }
        public double Balance { get; set; }
        Buscardor busca = new Buscardor();
        public void Apertura()
        {
            Random Cuenta = new Random();
            int Numero = Cuenta.Next(100000000, 900000000);
            this.NumeroDeCuenta = Numero;
            Console.WriteLine("Digite el monto de inicial.");
            double monto = Convert.ToDouble(Console.ReadLine());
            this.Balance = monto;
            Console.WriteLine("Su número de cuenta es " + Numero);
            Console.ReadKey();

            Repositorio.Instancia.Ahorro.Add(this);
        }

        public void consulta()
        {
            CuentaDeAhorro ahorro = new CuentaDeAhorro();
            Console.WriteLine("Digite su número de cuenta");
            int numeroCuenta = Convert.ToInt32(Console.ReadLine());
            ahorro = busca.BuscardorAhorro(numeroCuenta);
            if (ahorro.NumeroDeCuenta == 0)
            {
                Console.WriteLine("Numero de cuenta erronéo");
                Console.ReadKey();
            }
            else
            {
                
                Console.WriteLine("Su balance es de " + ahorro.Balance);
                Console.ReadKey();

            }
        }

        public void Depositos()
        {
            CuentaDeAhorro ahorro = new CuentaDeAhorro();
            Console.WriteLine("Digite su número de cuenta");
            int numeroCuenta = Convert.ToInt32(Console.ReadLine());
            ahorro = busca.BuscardorAhorro(numeroCuenta);
            if (ahorro.NumeroDeCuenta == 0)
            {
                Console.WriteLine("Numero de cuenta erronéo");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Digite el monto a depositar");
                double deposito = Convert.ToDouble(Console.ReadLine());
                ahorro.Balance = ahorro.Balance + deposito;
                Repositorio.Instancia.Ahorro.Add(ahorro);
                Console.WriteLine("Su balance es de " + ahorro.Balance);
                Console.ReadKey();

            }

        }

        public void Retiros()
        {
            CuentaDeAhorro ahorro = new CuentaDeAhorro();
            Console.WriteLine("Digite su número de cuenta");
            int numeroCuenta = Convert.ToInt32(Console.ReadLine());
            ahorro = busca.BuscardorAhorro(numeroCuenta);
            if (ahorro.NumeroDeCuenta == 0)
            {
                Console.WriteLine("Numero de cuenta erronéo");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Digite el monto a retirar.");
                double reti = Convert.ToDouble(Console.ReadLine());
                ahorro.Balance -= reti;
                Repositorio.Instancia.Ahorro.Add(ahorro);
                Console.WriteLine("Su balance es de " + ahorro.Balance);
                Console.ReadKey();
            }
        }

    }
}
