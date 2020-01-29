using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1
{
    class Reproductores
    {
        public void Play()
        {
            Console.WriteLine("Play ---------> Inicia la pelicula");

        }
        public void Stop()
        {
            Console.WriteLine("Stop ---------> Se detiene la pelicula");

        }
        public void FW()
        {
            Console.WriteLine("FW -----------> Se adelanta la pelicula");
        } 

        public void RW()
        {
            Console.WriteLine("RW -----------> Se devuelve la pelicula");
        }
    }
}
