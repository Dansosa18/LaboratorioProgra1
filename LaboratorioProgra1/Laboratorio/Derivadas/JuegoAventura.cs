using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.Derivadas
{
    internal class JuegoAventura : VideoJuego
    {
        public string Historia { get; set; }
        public bool MundoAbierto { get; set; }

        public override void IniciarPartida()
        {
            Console.WriteLine("  Explora un mundo lleno de Aventura.");
            base.IniciarPartida();
        }
    }
}
