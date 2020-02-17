using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_4.Helpers
{
    public class Calcular
    {
        public static double sumar(double a, double b)
        {
            double result = a + b;
            return (result);
        }

        public static double restar(double a, double b)
        {
            double result = a - b;
            return (result);
        }

        public static double multiplicar(double a, double b)
        {
            double result = a * b;
            return (result);
        }

        public static double dividir(double a, double b)
        {
            double result = a / b;
            return (result);
        }

        public static double al2(double a, double b)
        {
            double result = Math.Pow(a, 2);
            return (result);
        }

        public static double al3(double a, double b)
        {
            double result = Math.Pow(a, 3);
            return (result);
        }

        public static double aly(double a, double b)
        {
            double result = Math.Pow(a, b);
            return (result);
        }

        public static double log(double a, double b)
        {
            double result = Math.Log10(a);
            return (result);
        }

        public static double porcentaje(double a, double b)
        {
            double result = a * (b / 100);
            return (result);
        }

        public static double seno(double a, double b)
        {
            double result = Math.Sin(a);
            return (result);
        }

        public static double coseno(double a, double b)
        {
            double result = Math.Cos(a);
            return (result);
        }

        public static double tangente(double a, double b)
        {
            double result = Math.Tan(a);
            return (result);
        }
    }
}
