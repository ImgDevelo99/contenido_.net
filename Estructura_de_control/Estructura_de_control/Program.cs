using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////let numero = "hola"
            ////TIPO DE DATOS
            //int numero = 10;
            //string cadena = "Hola";
            //double decimal1 = 10.5;
            //long numeroGrande = 1000000000000000000;
            //bool bandera = true;
            //decimal precio = 10.5m;
            //char caracter = 'a';
            //float flotante = 10.5f;
            //int? edad = null;


            ////OPERADORES
            ////ARITMETICOS
            //int suma = 10 + 5;
            //int resta = 10 - 5;
            //int multiplicacion = 10 * 5;
            //int division = 10 / 5;
            //int modulo = 10 % 5;

            ////INCREMENTO Y DECREMENTO
            //int incremento = 10;
            //incremento++;
            //int decremento = 10;
            //decremento--;
            ////ASIGNACION
            //int asignacion = 10;
            //asignacion += 5;
            //Console.WriteLine(asignacion);//15
            //asignacion -= 5;
            //asignacion *= 5;
            //asignacion /= 5;
            //asignacion %= 5;
            ////COMPARACION
            //bool igual = 10 == 5; // ====
            //bool diferente = 10 != 5;
            //bool mayor = 10 > 5;
            //bool menor = 10 < 5;
            //bool mayorIgual = 10 >= 5;//true
            //bool menorIgual = 10 <= 5;//false
            ////LOGICOS
            //bool y = true && false;
            //bool o = true || false;
            //bool no = !true;
            ////TERNARIO
            //int edad1 = 10;
            //string mensaje = edad1 >= 18 ? "Es mayor de edad" : "Es menor de edad";
            ////if (edad1 >= 18)
            ////{
            ////    mensaje = "Es mayor de edad";
            ////}
            ////else
            ////{
            ////    mensaje = "Es menor de edad";
            ////}

            //Console.WriteLine(mensaje);
            ////CONDICIONALES
            //int edad2 = 10;
            //if (edad2 >= 18)
            //{
            //    Console.WriteLine("Es mayor de edad");
            //}
            //else if (edad2 >= 10)
            //{
            //    Console.WriteLine("Es un niño");
            //}
            //else if (edad2 >= 5)
            //{
            //    Console.WriteLine("Es un bebe");
            //}
            //else
            //{
            //    Console.WriteLine("Es menor de edad");
            //}
            ////SWITCH
            //int dia =6;
            //switch (dia)
            //{
            //    case 1:
            //        Console.WriteLine("Lunes");
            //        break;
            //    case 2:
            //        Console.WriteLine("Martes");
            //        break;
            //    case 3:
            //        Console.WriteLine("Miercoles");
            //        break;
            //    case 4:
            //        Console.WriteLine("Jueves");
            //        break;
            //    case 5:
            //        Console.WriteLine("Viernes");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sabado");
            //        break;
            //    case 7:
            //        Console.WriteLine("Domingo");
            //        break;
            //    default:
            //        Console.WriteLine("No es un dia de la semana");
            //        break;
            //}
            ////CICLOS
            ////FOR
            //for (int i = 0; i <= 10; i++)//inicializacion, condicion, actualizacion
            //{
            //    Console.WriteLine("numero: " + i);
            //}
            ////WHILE
            //Console.WriteLine("--------BULE WHILE-------------");
            //int j = 0;
            //while (j <= 10)// primero evalua la condicion y luego ejecuta
            //{
            //    Console.WriteLine("numero: " + j);
            //    j++;
            //}
            ////DO WHILE
            //Console.WriteLine("--------BULE DO WHILE-------------");
            //int k = 0;
            //do
            //{
            //    Console.WriteLine("numero: " + k);
            //    k++;
            //} while (k <= 10);//primero ejecuta y luego evalua la condicion

            ////FOREACH
            //Console.WriteLine("--------BULE FOREACH-------------");
            //string[] nombres = { "Juan", "Pedro", "Maria" };
            //foreach (string nombre in nombres)
            //{
            //    Console.WriteLine("nombre: " + nombre);
            //}
            ////BREAK

            //Console.WriteLine("--------BULE BREAK-------------");
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("numero: " + i);
            //}
            ////CONTINUE
            //Console.WriteLine("--------BULE CONTINUE-------------");
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("numero: " + i);
            //}
            ////RETURN
            //Console.WriteLine("--------BULE RETURN-------------");
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        return;
            //    }
            //    Console.WriteLine("numero: " + i);
            //}


            ////resolver un ejercicio con estructura de control
            ////1. Crear un programa que pida al usuario un número entero y muestre en pantalla si es par o impar.
            //Console.WriteLine("--------QUIERE SABER SI ES PAR O IMPAR?--------------");
            //Console.WriteLine("Ingrese un numero entero: ");//"5"

            //int numero1 = int.Parse(Console.ReadLine()); //ReadLine = para leer la entrada del usuario

            //if (numero1 % 2 == 0)
            //{
            //    Console.WriteLine("El numero que usted ingreso es: " +  numero1  + " Es Par");
            //}
            //else 
            //{
            //    Console.WriteLine($"el numero que usted ingreso {numero1} es impar");
            //}

            //-------------------------------------------------------------------------------------------
            // pedirle al usuario las 3 notas donde la primera nota equivale al 20 %, segunda nota 30 %, 
            //    tercera nota 50 %, se debe calificar de 1 a 5, no se debera permitir que el usuario ingrese un numero 
            //    fuera de ese rango. al final debe mostrar un mensaje si el estudiante aprobo o no aprobo.

            double nota1, nota2, nota3, promedio;

            while (true)
            {
                Console.WriteLine("Ingrese la primera nota (equivale al 20 %)");
                nota1 = double.Parse(Console.ReadLine());

                if (nota1 >= 1 && nota1 <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nota invalida, por favor ingresar una nota entre 1 y 5");
                }
            }

            while (true)
            {
                Console.WriteLine("Ingrese la segunda nota (equivale al 30 %)");
                nota2 = double.Parse(Console.ReadLine());

                if (nota2 >= 1 && nota2 <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nota invalida, por favor ingresar una nota entre 1 y 5");
                }
            }

            while (true)
            {
                Console.WriteLine("Ingrese la tercera nota (equivale al 50 %)");
                nota3 = double.Parse(Console.ReadLine());

                if (nota3 >= 1 && nota3 <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nota invalida, por favor ingresar una nota entre 1 y 5");
                }
            }

            promedio = (nota1 * 0.2) + (nota2 * 0.3) + (nota3 * 0.5);
            Console.WriteLine($"El promedio es {promedio}");

            if (promedio >= 3)
            {
                Console.WriteLine("Felicitaciones aptobo .NET");
            }
            else
            {
                Console.WriteLine("lo siento mucho No aprobo");
            }

            //-------------------------------------------------------------------------------------------------------------------

            // Desarrollar un programa en C# que solicite al usuario el precio de un producto y aplique un descuento basado en su valor.

            //Condiciones:
            //Si el precio del producto es mayor o igual a $100.000, se aplica un descuento del 20 %.
            //Si el precio es menor a $100.000, no se aplica descuento.
            //El programa debe mostrar el precio final después de aplicar el descuento.

            //solicitar el precio del producto

            Console.WriteLine("Ingrese el precio del producto");// 1000000
            double precio = double.Parse(Console.ReadLine());

            double descuento = 0;

            //estructura de control if-else
            if (precio >= 100.000) // 100000 == 100.000
            {
                descuento = 0.20; // decuento del 20%
            }
            else if (precio >= 50.000 && precio <= 99.000)
            {
                descuento = 0.10; // descuento del 10%
            }
            else
            {
                descuento = 0.5;
            }

            //calcular el precio final
            double precioFial = precio - (precio * descuento);

            Console.WriteLine($"Decuento aplicado: {descuento * 100}%");
            Console.WriteLine($"precio final: {precioFial}");

            //swith mostrar los mensajes
            switch (descuento)
            {
                case 0.20:
                    Console.WriteLine("Gran descuento aplicado");
                    break;
                case 0.10:
                    Console.WriteLine("descuento moderado");
                    break;
                case 0.05:
                    Console.WriteLine("pequeño descuento aplicado");
                    break;
                default:
                    Console.WriteLine("Sin descuento");
                    break;
            }

            //for para mostrar descuentos
            Console.WriteLine("\n Proximos descuento");

            for (int i = 1; i <= 5; i++)
            {
                double nuevoPrecio = precio - (precio * (i * 0.5));
                Console.WriteLine($"Descuento {i * 5}% -> precio final: {nuevoPrecio}");
            }
        }
         // tv si vale 100.000 tenga futuras promociones
    }
}
