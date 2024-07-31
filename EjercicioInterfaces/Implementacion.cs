using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Implementacion : IOperaciones
    {
        public double numero1;

        public double numero2;

        public Implementacion()
        {

        }

        public Implementacion(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }
       public double Area()
        {
            double area = numero1 * numero2;
            return area;
        }


       public double NumeroMayor()
        {
            return Math.Max(numero1, numero2);
        }

       public double NumeroMenor()
        {
            return Math.Min(numero1,numero2);
        }

        public double Potencia()
        {
            return Math.Pow(numero1, numero2);
        }

       public double RaizCuadrada()
        {
            return Math.Sqrt(numero1);
            
        }

        public double RaizCuadrada2()
        {
            return Math.Sqrt(numero2);
        }

        public void Imprimir()
        {
            Console.WriteLine("*****RESULTADOS*****");
            Console.WriteLine($"El area calculada es:  {Area()}");
            Console.WriteLine($"El numero mayor es:  {NumeroMayor()}");
            Console.WriteLine($"El numero menor es:  {NumeroMenor()}");
            Console.WriteLine($"La raiz cuadrada del primer numero es :  {RaizCuadrada()}");
            Console.WriteLine($"La raiz cuadrada del segundo numero es :  {RaizCuadrada2()}");
            Console.WriteLine();
        }
    }

}
