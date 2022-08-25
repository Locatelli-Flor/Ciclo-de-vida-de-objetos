//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for (int i = 0; i<100; i++)
            {
                string aux = $"tren{i}";
                var tren = new Train($"Tren {i}");
            }
            //Al crear tantas instancias de la clase Train, se va llenando la memoria de heap. 
            //Entonces el runtime empieza a eliminarlos para liberar el espacio de memoria.
            for (int i = 0; i<100000; i++)
            {
                string aux = $"tren{i}";
                var tren = new Train($"Tren {i}");
            }

            Train t1;
            t1 = new Train("Last Train To London");
            Train t2;
            t2 = new Train("Last Train To London");
            Train t3;
            t3 = new Train ("Runaway Train");

            Console.WriteLine($"{t1 == t2}, {t2 == t3}");
            //Ambas proposiciones son falsas. Cada variable (t1, t2 y t3) hace referencia a un objeto diferente ya que al momento de
            //la asignación se crea un objeto nuevo a través del new. Entonces por más de que t1 y t2 tengan el mismo identificador, refieren a espacios de memoria distintos. Lo mismo con t3.
        }
    }
}