using System;

namespace OPERACIONES_ARITMETICAS
{
    public class ARITMETICAS
    {
        //Metodo con retorno y parametros para SUMAR
        public static int Sumar(int valor1, int valor2)
        {
            return (valor1 + valor2);
        }
        //Metodo con retorno y parametros para RESTAR
        public static int Restar(int valor1, int valor2)
        {
            return (valor1 - valor2);
        }
        //Metodo con retorno y parametros para MULTIPLICAR
        public static double Multiplica(int valor1, int valor2)
        {
            return (valor1 * valor2);
        }
        //Metodo con retorno y parametros para DIVIDIR
        public static int Divide(int valor1, int valor2)
        {
            if (valor2 == 0)
            {
                Console.WriteLine("No se puede dividir un numero entre 0");
                return 0;
            }
            else
            {
                return (valor1 / valor2);
            }
            public static double Multiplica(int valor1, int valor2)
        {
            return (valor1 * valor2);
        }
        //Metodo con retorno y parametros para POTENCIA
        public static int Potencia(int valor1, int valor2)
        {
            int contador;
            double Acomulador = 1;
            
            for (contador = 1; contador <= valor2; contador++)

            
            {
                Console.WriteLine("No se puede dividir un numero entre 0");
            }
        }
    }
    }
}
