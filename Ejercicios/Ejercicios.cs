using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace EjerciciosPracticos2_Arryas_SAEG.Ejercicios
{
    public class EjerciciosClase
    {
        //Solicitar valores numéricos en dos arreglos distintos y almacenar el resultado de la suma 
        //de los valores en cada posición(posición 0 del arreglo 1 + posición 0 del arreglo 2) 
        //en un tercer arreglo.Luego, mostrar el contenido de los tres arreglos de la siguiente manera:
        //valor en la posición 0 del arreglo 1 + valor en la posición 0 del arreglo 2 = valor en la posición 0 del arreglo 3
        //valor en la posición 1 del arreglo 1 + valor en la posición 1 del arreglo 2 = valor en la posición 1 del arreglo 3. 
        public void PrimerEjercicio()
        {
            Console.WriteLine("Ingrese la longitud de los 3 arrays: ");
            int longitudArreglos = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[longitudArreglos];
            int[] array2 = new int[longitudArreglos];
            int[] resultado = new int[longitudArreglos];
            for(int i = 0; i < longitudArreglos; i++)
            {
                Console.WriteLine("Ingresa el valor {0} en el arreglo 1: ",i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el valor {0} en el arreglo 2: ",i);
                array2[i] = Convert.ToInt32(Console.ReadLine());
                resultado[i] = array1[i] + array2[i];
            }
            for(int j = 0; j < longitudArreglos; j++)
            {
                Console.WriteLine("valor en la posición {3} del arreglo 1 ({0}) " +
                    "+ valor en la posición {3} del arreglo 2 ({1})" +
                    "= valor en la posición {3} del arreglo 3 ({2})", array1[j], array2[j], resultado[j],j);
            }
        }
        //Buscar un elemento ingresado desde el teclado en un arreglo y guardar las posiciones en otro arreglo.
        //Si hay más de una coincidencia, indicar igualmente la posición.
        public void SegundoEjercicio()
        {
            int[] arrayIngresados = new int[3];
            int[] arrayPosiciones = new int[3];
            for(int i = 0; i< arrayIngresados.Length; i++)
            {
                Console.WriteLine("Ingrese el valor {0}", i);
                arrayIngresados[i] = Convert.ToInt32(Console.ReadLine());
                
            }
        }
        //Solicitaremos los IDs(números) de los alumnos de dos clases y los guardaremos en dos arreglos con los nombres 
        //'álgebra' y 'análisis'. Queremos mostrar a todos los alumnos que están inscritos en ambas asignaturas.Estos 
        //alumnos se guardarán en un tercer arreglo, el cual se mostrará. También se indicará el número de alumnos que se repiten.
        public void TercerEjercicio()
        {

        }
        //Solicitar por entrada de teclado el tamaño de un arreglo de números y luego ingresar los valores numéricos para llenarlo.
        //Los valores no deben repetirse. Al finalizar, mostrar el contenido del arreglo con los valores ingresados.
        public void CuartoEjercicio()
        {

        }
        //Dado un arreglo de N notas, cada una en un rango de 0 a 20, calcule el promedio de las notas aprobadas y el promedio de las notas desaprobadas.
        //Además, indique la cantidad de notas aprobadas y desaprobadas en el arreglo.Los rangos son los siguientes:
        //Deficientes 0-5
        //Regulares 6-10
        //Buenos 11-15
        //Excelentes 16-20
        public void QuintoEjercicio()
        {
            Console.WriteLine("Ingrese la cantidad de calificaciones que desea promediar: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] calificacionesIngresadas = new int[longitud];
            int aprobados = 0;
            int reprobados = 0;
            for(int i = 0; i < longitud; i++)
            {
                Console.WriteLine("Ingresa la calificacion {0}: ", i + 1);
                calificacionesIngresadas[i] = Convert.ToInt32(IngresoCalificaciones());
                if (!AprobadoReprobado(calificacionesIngresadas[i]))
                {
                    reprobados++;
                }
                else
                {
                    aprobados++;
                }
            }
            Console.WriteLine("El promedio de notas desaprobadas es del {0}%",PromedioAlumnos(reprobados,longitud));
            Console.WriteLine("");
            Console.WriteLine("Y el promedio de notas aprobatorias es del {0}%", PromedioAlumnos(aprobados, longitud));
        }
        public int IngresoCalificaciones()
        {
            int calificacion = Convert.ToInt32(Console.ReadLine());
            if (calificacion < 0 || calificacion > 20)
            {
                return 0;
            }
            else
            {
                return calificacion;
            }
        }
        public bool AprobadoReprobado(int calificacion)
        {
            if (calificacion <= 10 && calificacion >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public double PromedioAlumnos(int calificacion, int cantidadAlumnos)
        {
            double promedio = Convert.ToDouble(calificacion);
            promedio /= Convert.ToDouble(cantidadAlumnos);
            return promedio * 100;
        }
    }
}
