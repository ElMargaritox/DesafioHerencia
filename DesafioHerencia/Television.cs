using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Television : Electrodomestico
    {

        private float resolucion = 20;
        private bool sintonizador_tdt = false;

        public Television()
        {
        }

        public Television(float precio, float peso) : base(precio, peso)
        {
        }

        public Television(float resolucion, bool sintonizador, float precio, float peso, string color, char consumoEnergetico) : base(precio, peso, color, consumoEnergetico)
        {
            this.resolucion = resolucion;
            this.sintonizador_tdt = sintonizador;
        }

        public override void precioFinal()
        {

            if (resolucion > 40) base.Precio += (Precio * 30) / 100;
            if (sintonizador_tdt) base.Precio += (Precio * 50) / 100;
            base.precioFinal();
        }

        public float Resolucion { get => resolucion; }
        public bool Sintonizador_tdt { get => sintonizador_tdt;}
    }
}
