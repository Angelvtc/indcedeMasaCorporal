using System;
using System.IO.Pipes;
using IndiceDeMasaCorporal;

namespace IndiceDeMasaCorporal
{
    public class IMC
    {
        // Propiedades públicas
        public double peso { get; set; }
        public double estatura { get; set; }

        // Constructor
        public IMC(double peso, double estatura)
        {
            this.peso = peso;
            this.estatura = estatura;
        }

        // Método para calcular y retornar el IMC
        public double Calcular()
        {
            double imc = peso / Math.Pow(estatura, 2);

            // Mostrar categoría según el valor de IMC
            if (imc < 18.5)
            {
                Console.WriteLine("Tu peso es bajo.");
            }
            else if (imc >= 18.5 && imc < 25.0)
            {
                Console.WriteLine("Tu peso es normal.");
            }
            else if (imc >= 25.0 && imc < 30.0)
            {
                Console.WriteLine("Tienes sobrepeso.");
            }
            else if (imc >= 30.0 && imc < 40.0)
            {
                Console.WriteLine("Tienes obesidad.");
            }
            else if (imc >= 40.0)
            {
                Console.WriteLine("Tienes obesidad extrema.");
            }
            else
            {
                Console.WriteLine("Valor no válido.");
            }

            return imc;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos datos al usuario
            Console.WriteLine("Escribe tu peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Escribe tu estatura:");
            double estatura = double.Parse(Console.ReadLine());

            // Creamos una instancia de la clase IMC
            IMC usuario = new IMC(peso, estatura);

            // Calculamos el IMC y mostramos el resultado
            double imc = usuario.Calcular();
            Console.WriteLine($"Tu IMC es {imc}");
        }
    }

}

