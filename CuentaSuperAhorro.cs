using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class CuentaSuperAhorro 
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

            Repositorio.Instancia.SuperAhorro.Add(this);
        }

        public void consulta()
        {
            CuentaSuperAhorro ahorro = new CuentaSuperAhorro();
            Console.WriteLine("Digite su número de cuenta");
            int numeroCuenta = Convert.ToInt32(Console.ReadLine());
            ahorro = busca.BuscardorSuper(numeroCuenta);
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
            CuentaSuperAhorro ahorro = new CuentaSuperAhorro();
            Console.WriteLine("Digite su número de cuenta");
            int numeroCuenta = Convert.ToInt32(Console.ReadLine());
            ahorro = busca.BuscardorSuper(numeroCuenta);
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
                Repositorio.Instancia.SuperAhorro.Add(ahorro);
                Console.WriteLine("Su balance es de " + ahorro.Balance);
                Console.ReadKey();

            }
        }

        public void Retiro()
        {
            CuentaSuperAhorro ahorro = new CuentaSuperAhorro();
            Console.WriteLine("Digite su número de cuenta");
            int numeroCuenta = Convert.ToInt32(Console.ReadLine());
            ahorro = busca.BuscardorSuper(numeroCuenta);
            if (ahorro.NumeroDeCuenta == 0)
            {
                Console.WriteLine("Numero de cuenta erronéo");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Digite el monto a retirar.");
                double reti = Convert.ToDouble(Console.ReadLine());
                if (ValidarRetiros(reti, ahorro.Balance))
                {
                    ahorro.Balance = ahorro.Balance - reti;
                    Repositorio.Instancia.SuperAhorro.Add(ahorro);
                    Console.WriteLine("Su balance es de " + ahorro.Balance);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El monto supera el 40% de balance.");
                    Console.ReadKey();
                }

            }
        }

        public bool ValidarRetiros(double retiro, double balance)
        {
            double valor = balance * 0.40;
            if(retiro > valor)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
