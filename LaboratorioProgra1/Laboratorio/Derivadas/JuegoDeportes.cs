using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.Derivadas
{
    internal class JuegoDeportes : VideoJuego
    {
        public string Deporte { get; set; }
        public bool Equipo { get; set; }

        public override void IniciarPartida()
        {
            Console.WriteLine ("A crear Equipos y a jugar ");
            base.IniciarPartida();
        }
    }
}
