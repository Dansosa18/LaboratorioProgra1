using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.Derivadas
{
    internal class JuegoAccion : VideoJuego
    {
        public int NivelDificultad { get; set; }
        public bool TieneMultijugador { get; set; }

        public override void IniciarPartida()
        {
            Console.WriteLine("Preparate para comenzar este emocionante juego de accion");
            base.IniciarPartida();
        }


    }
}
