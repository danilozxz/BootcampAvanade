using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
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
            Console.WriteLine($"{x} * {y} = {resultado}");
        }
        public void Dividir(int x, int y)
        {
            int resultado = x / y;
            Console.WriteLine($"{x} / {y} = {resultado}");
        }

        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"O tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}