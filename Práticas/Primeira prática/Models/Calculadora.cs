using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prática_sozinho.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            int resultado = x + y;
            Console.WriteLine($"{x} + {y} = {resultado}");
        }
        public void Subtrair(int x, int y)
        {
            int resultado = x - y;
            Console.WriteLine($"{x} - {y} = {resultado}");
        }
        public void Multiplicar(int x, int y)
        {
            int resultado = x * y;
            Console.WriteLine($"{x} x {y} = {resultado}");
        }
        public void Dividir(int x, int y)
        {
            int resultado = x / y;
            Console.WriteLine($"{x} / {y} = {resultado}");
        }

        public void Seno(int angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)} ");
        }
        public void Coseno(int angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }
        public void Tangente(int angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)} ");
        }

        public void Raiz(double x)
        {
            double resultado = Math.Sqrt(x);
            Console.WriteLine($"Raiz de {x} = {resultado}");
        }
    }
}