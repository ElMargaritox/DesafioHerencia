using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Electrodomestico
    {
        private float precio = 100, peso = 5;
        private string color = "blanco";
        private char consumoEnergetico = 'F';


        public Electrodomestico() { }

        public Electrodomestico(float precio, float peso)
        {
            this.precio = precio;
            this.peso = peso;
        }

        public Electrodomestico(float precio, float peso, string color, char consumoEnergetico)
        {
            this.precio = precio;
            this.peso = peso;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
        }

        private void comprobarconsumoEnergetico(char letra)
        {
            if(letra == 'A' || letra == 'B' || letra == 'C' || letra == 'D' || letra == 'E'  || letra == 'F')
            {
                consumoEnergetico = letra;
            }
            else
            {
                consumoEnergetico = 'F';
            }
        }

        private void comprobarColor(string color)
        {
            if(color == "blanco" || color == "negro" || color == "rojo" || color == "azul" || color == "gris")
            {
                this.color = color;
            }
            else
            {
                this.color = "blanco";
            }
        }

        public virtual void precioFinal()
        {
            
            if (this.consumoEnergetico == 'A') this.precio += 100;
            else if (this.consumoEnergetico == 'B') this.precio += 80;
            else if (this.consumoEnergetico == 'C') this.precio += 60;
            else if (this.consumoEnergetico == 'D') this.precio += 50;
            else if (this.consumoEnergetico == 'E') this.precio += 30;
            else this.precio += 10;

            if (this.peso >= 0 && this.peso <= 19) this.precio += 10;
            else if (this.peso >= 20 && this.peso <= 49) this.precio += 50;
            else if (this.peso >= 50 && this.peso <= 79) this.precio += 80;
            else this.precio += 100;

            Console.WriteLine("El Precio Final Es De: {0}", this.precio);
        }


        public float Peso { get => peso;}
        public string Color { get => color; }
        public char ConsumoEnergetico { get => consumoEnergetico;}
        public float Precio { get => precio; set => precio = value; }
    }
}
