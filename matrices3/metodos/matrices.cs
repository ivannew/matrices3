using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices3.metodos
{
    internal class matrices
    {
        public void HacerEjercicio1()
        {
            int[,]arreglo1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Valores del 1 al 9 son:");

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(arreglo1[fila, columna] + " ");
                }
            }

            Console.WriteLine();
        }

        public void HacerEjercicio2()
        {
            string[,] arreglo2 = { { "rojo", "verde" }, { "azul", "amarillo" } };

            Console.WriteLine("los colores son :");
            for(int fila=0; fila<2; fila++)
            {
                for( int columna=0; columna <2; columna++)
                {
                    Console.WriteLine(arreglo2[fila,columna]+" ");
                }

            }
            Console.WriteLine();
        }

        public void HacerEjercicio3()
        {
            double[,] arreglo3 = {{1.1,1.2,1.3},{2.1,2.2,2.3 },{3.1,3.2,3.3 },{4.1,4.2,4.3} };
            double suma=0.0;
            for(int fila=0; fila<4; fila++)
            {
                for(int columna = 0; columna < 3; columna++)
                {
                    suma += arreglo3[fila, columna];
                }
                    

            }
            Console.WriteLine("Suma de todos los elementos del arreglo " + suma);
        }
        public void HacerEjercicio4()
        {
            char[,] arreglo4 = {
            {'a','b','c','d'},
            {'e','f','g','h'},
            
        };

            Console.WriteLine("Matriz en forma de tabla:");
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.Write(arreglo4[fila, columna] + " ");
                }
                Console.WriteLine(); 
            }
        }
    }
}
