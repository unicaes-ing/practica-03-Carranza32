using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica3MC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Escoja una opcion");
                Console.WriteLine("1 - Ejercicio 1");
                Console.WriteLine("2 - Ejercicio 2");
                Console.WriteLine("3 - Ejercicio 3");
                Console.WriteLine("4 - Ejercicio 4");
                Console.WriteLine("5 - Ejercicio 5");
                Console.WriteLine("6 - Ejercicio 6");
                Console.WriteLine("7 - Ejercicio 7");
                Console.WriteLine("8 - Ejercicio 8");
                Console.WriteLine("0 - Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicio4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Ejercicio5();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Ejercicio6();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Ejercicio7();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Ejercicio8();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }

        static void Ejercicio1()
        {
            Console.WriteLine("Ingrese el tiempo en horas");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Horas: {0}, minutos: {1}, segundos:{2}", horas, horas * 60, horas * 3600);
        }

        private static void Ejercicio2()
        {
            Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {
                int numero = random.Next(1, 100);
                if (numero % 2 == 0)
                {
                    Console.WriteLine("{0} es par", numero);
                }
                else
                {
                    Console.WriteLine("{0} es impar", numero);
                }
            }
        }

        private static void Ejercicio3()
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("{0},{1},{2}", num3, num2, num1);
                }
                else
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("{0},{1},{2}", num2, num3, num1);
                    }
                    else
                    {
                        Console.WriteLine("{0},{1},{2}", num2, num1, num3);
                    }
                }
            }
            else
            {
                if (num1 > num3)
                {
                    Console.WriteLine("{0},{1},{2}", num3, num1, num2);
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("{0},{1},{2}", num1, num3, num2);
                    }
                    else
                    {
                        Console.WriteLine("{0},{1},{2}", num1, num2, num3);
                    }
                }
            }
        }

        private static void Ejercicio4()
        {
            Console.WriteLine("Ingrese la duracion de la llamada");
            int duracion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su zona de procedencia");
            Console.WriteLine("1 - Zona Occidental");
            Console.WriteLine("2 - Zona Central");
            Console.WriteLine("3 - Zona Oriental");

            int opc = Convert.ToInt32(Console.ReadLine());
            double costo = 0.0;

            switch (opc)
            {
                case 1:
                    costo = 0.32;
                    break;
                case 2:
                    costo = 0.25;
                    break;
                case 3:
                    costo = 0.36;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Total a pagar: {0:N2}", duracion * costo);
        }

        private static void Ejercicio5()
        {
            string[] numeros = new[] { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez"};
            Console.WriteLine("Ingrese un numero del 1 - 10");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numeros[num-1]);
        }

        private static void Ejercicio6()
        {
            Console.WriteLine("Ingrese el monto de compra");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            if (cantidad >= 0 && cantidad <= 100)
            {
                Console.WriteLine("No hay descuento");
                Console.WriteLine("Total a pagar: {0:N2}", cantidad);
            }
            else if(cantidad >= 100.01 && cantidad <= 200)
            {
                Console.WriteLine("12% de descuento");
                Console.WriteLine("Total a pagar: {0:N2}", cantidad - (cantidad * 0.12));
            }
            else if (cantidad >= 200.01 && cantidad <= 500)
            {
                Console.WriteLine("15% de descuento");
                Console.WriteLine("Total a pagar: {0:N2}", cantidad - (cantidad * 0.15));
            }
            else if (cantidad >= 500.01)
            {
                Console.WriteLine("20% de descuento");
                Console.WriteLine("Total a pagar: {0:N2}", cantidad - (cantidad * 0.20));
            }
        }

        private static void Ejercicio7()
        {
            Console.WriteLine("Selecciona la unidad de origen");
            Console.WriteLine("1 - Onza");
            Console.WriteLine("2 - Libra");
            Console.WriteLine("3 - Gramo");
            Console.WriteLine("4 - Tonelada");
            int origen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cantidad a convertir");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona la unidad de destino");
            int destino = Convert.ToInt32(Console.ReadLine());

            switch (origen)
            {
                case 1:
                    if (destino == 2)
                    {
                        Console.WriteLine("{0} Onzas a libras: {1:N2}", cantidad, cantidad * 0.0625);
                    }
                    else if(destino == 3)
                    {
                        Console.WriteLine("{0} Onzas a gramos: {1:N2}", cantidad, cantidad * 28.3495);
                    }
                    else if (destino == 3)
                    {
                        Console.WriteLine("{0} Onzas a toneladas: {1:N2}", cantidad, cantidad * 2.835);
                    }
                    else
                    {
                        Console.WriteLine("Onzas {0:N2}", cantidad);
                    }
                    break;
                case 2:
                    if (destino == 1)
                    {
                        Console.WriteLine("{0} Libras a onzas: {1:N2}", cantidad, cantidad * 16);
                    }
                    else if (destino == 3)
                    {
                        Console.WriteLine("{0} Libras a gramos: {1:N2}", cantidad, cantidad * 453.592);
                    }
                    else if (destino == 4)
                    {
                        Console.WriteLine("{0} Libras a toneladas: {1:N2}", cantidad, cantidad * 0.000453592);
                    }
                    else
                    {
                        Console.WriteLine("Libras {0:N2}", cantidad);
                    }
                    break;
                case 3:
                    if (destino == 1)
                    {
                        Console.WriteLine("{0} Gramos a onzas: {1:N2}", cantidad, cantidad * 0.035274);
                    }
                    else if (destino == 2)
                    {
                        Console.WriteLine("{0} Gramos a libra: {1:N2}", cantidad, cantidad * 0.00220462);
                    }
                    else if (destino == 4)
                    {
                        Console.WriteLine("{0} Gramos a toneladas: nose como se hace :'v ", cantidad);
                    }
                    else
                    {
                        Console.WriteLine("Gramos {0:N2}", cantidad);
                    }
                    break;
                case 4:
                    if (destino == 1)
                    {
                        Console.WriteLine("{0} Tonelada a onzas: {1:N2}", cantidad, cantidad * 35274);
                    }
                    else if (destino == 2)
                    {
                        Console.WriteLine("{0} Tonelada a libra: {1:N2}", cantidad, cantidad * 2204.62);
                    }
                    else if (destino == 3)
                    {
                        Console.WriteLine("{0} Tonelada a gramos: nose como se hace :'v ", cantidad);
                    }
                    else
                    {
                        Console.WriteLine("Tonelada {0:N2}", cantidad);
                    }
                    break;
                default:
                    break;
            }
        }

        private static void Ejercicio8()
        {
            Random random = new Random();
            string[] bolitas = new string[] { "blanca", "verde", "amarilla", "azul", "roja" };
            string bolita = bolitas[random.Next(0, 5)];

            Console.WriteLine("Ingrese el valor de la compra total");
            double cantidad = Convert.ToDouble(Console.ReadLine());
            double descuento = 0.0;

            if (bolita == "verde") descuento = 0.15;
            if (bolita == "amarilla") descuento = 0.18;
            if (bolita == "azul") descuento = 0.20;
            if (bolita == "roja") descuento = 0.25;

            Console.WriteLine("Bolita: {0}, Descuento: {1}, Total: {2:N2}", bolita, descuento, cantidad - (cantidad * descuento));
        }
    }
    
}
