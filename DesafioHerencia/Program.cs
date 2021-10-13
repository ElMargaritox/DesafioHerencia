using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();

            Electrodomestico television = new Television(5f, true, 500, 35, "blanco", 'C');
            Electrodomestico television2 = new Television(15f, true, 200, 60, "negro", 'A');
            Electrodomestico lavadora = new Lavadora(5f, 700, 50, "rojo", 'F');

            electrodomesticos.Add(television);
            electrodomesticos.Add(television2);
            electrodomesticos.Add(lavadora);

            
            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                Console.WriteLine(electrodomestico.GetType().Name);
                electrodomestico.precioFinal();

            }
        }
    }
}
