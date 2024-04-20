using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    /// <summary>
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;

        public string Titulo
            
        {
            get { return titulo; }
            set { titulo = value; }

        }
     
        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                //  La calificación debe estar entre 0 y 10
                if (value >= 0 && value <=10)

                {
                    calificacion = value;
                }
                else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }

            }
            //Correccion: Se modifico la logica de la seccion set para que solo asigne la calificación a la variable si se encuentra dentro del rango válido
        }

        public int AnioLanzamiento
        // Error lógico: El año de lanzamiento 
        {
            get { return anioLanzamiento; }
            set
            {
                if (value <= DateTime.Now.Year)
                {
                    anioLanzamiento = value;
                }
                else
                {
                    Console.WriteLine("El año de lanzamiento no puede ser futuro.");
                }
            }
           
            //Corrección: Se agrega una validación para verificar si el año de lanzamiento es menor o igual al año actual.

        }



        public void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Desarrolladora: " + Desarrolladora);
            Console.WriteLine("Calificación: " + Calificacion);
            Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }


        public virtual void  IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            // Error lógico
            jugando = false;
            Console.WriteLine("Partida detenida.");
            //Corrección: Se agrega la línea para cambiar el valor de jugando a false.
        }

        public void TerminarJuego()
        {
            // Error lógico
            if (jugando)
            {
                jugando = false;

                Console.WriteLine("Juego terminado.");
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        //Corrección: Se agrega una verificación adicional para evitar terminar el juego dos veces.
        }

    }
}
