using System;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            IBanco tipo;
            Buscardor buscar = new Buscardor();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Qué tipo de cuenta va a tramitar?\n(1)Ahorro.\n(2)Super Ahorro. ");
                string opcion = Console.ReadLine();
                if(opcion == "1")
                {
                    tipo = new CuentaDeAhorro();
                }
                else
                {
                    tipo = new Adapter();
                }
                Console.Clear();
                Console.WriteLine("Qué acción deseas realizar?\n(1)Apertura\n(2)Deposito\n(3)Retiro\n(4)Consulta");
                string tipoTramite = Console.ReadLine();
                switch (tipoTramite)
                {
                    case "1":
                        tipo.Apertura();
                            break;
                    case "2":
                        tipo.Depositos();
                        break;
                    case "3":
                        tipo.Retiros();
                        break;
                    case "4":
                        tipo.consulta();
                        break;

                    default:Console.WriteLine("Opción no valida");
                        break;
                }

            }
            


        }
    }
}
