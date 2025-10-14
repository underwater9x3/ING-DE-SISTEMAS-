using System;

namespace SEMANA_9
{
    class Menu
    {
        public static int ElijeOperacion()
        {
            int Numero;
            do
            {

                Console.WriteLine("[1] SUMAR)");
                Console.WriteLine("[2] RESTAR)");
                Console.WriteLine("[3] MULTIPLICAR)");
                Console.WriteLine("[4] DIVIDIR)");
                Console.WriteLine("[5] POTENCIA)");
                Console.WriteLine("[6] SALIR)");

                Console.WriteLine("Ingrese el numero de operacion [1-6]: ");
                Numero = Convert.ToInt32(Console.ReadLine());

                if (Numero < 1 || Numero > 6)
                {
                    Console.WriteLine("Ingrese un numero valido, vuelva a ingresar");
                    Console.WriteLine("Presione cualquier tecla para continuar....");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (Numero < 1 || Numero > 6);
            return Numero;


        }
    }
}
