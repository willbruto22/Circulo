using System;
using System.Globalization;

namespace calculadora
{
    class Programcalc
    {
        calculadoracirc calc = new calculadoracirc();// chama a classe de calculo

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// Conversor para ler o valor em string

            double circ = calculadoracirc.Circunferencia(raio); //calculo da circunferencia
            double volume = calculadoracirc.volume(raio);//calculo do raio

            Console.WriteLine("Circunferencia:" + circ.ToString("F2", CultureInfo.InvariantCulture));// mostra o valor da circunferencia
            Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.Invariant));//mostra o valor do volume
            Console.WriteLine("Valor de Pi:" + calculadoracirc.Pi.ToString("F2", CultureInfo.Invariant));// calcula o valor de Pi

        }
    }
    
}
