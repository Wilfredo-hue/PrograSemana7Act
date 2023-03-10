using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGpt
{
    

    class Shoe
    {
        public string style;
        public string brand;
        public int size;
        public double price;
        public bool descuento;

        public Shoe(string style, string brand, int size, double price, bool descuento)
        {
            this.style = style;
            this.brand = brand;
            this.size = size;
            this.price = price;
            this.descuento = descuento;
        }

        public void PrintInfo()
        {
            string descuentoText = descuento ? "Si" : "No";
            Console.WriteLine("{0} {1} - Size {2} - ${3} - Discount: {4}", style, brand, size, price, descuentoText);
        }
    }

    class Store
    {
        public string name;
        public Shoe[] shoes;

        public Store(string name, Shoe[] shoes)
        {
            this.name = name;
            this.shoes = shoes;
        }

        public void PrintCatalog()
        {
            Console.WriteLine("Catalogo Para {0}:", name);
            Console.WriteLine("---------------------------------------");
            foreach (Shoe shoe in shoes)
            {
                shoe.PrintInfo();
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creamos las tiendas y los zapatos disponibles.
            Store[] stores = {
            new Store("Tienda A", new Shoe[] {
                new Shoe("Running Shoes", "Nike", 10, 100.0, false),
                new Shoe("Sneakers", "Adidas", 9, 80.0, true),
                new Shoe("Boots", "Timberland", 11, 120.0, false)
            }),
            new Store("Tienda B", new Shoe[] {
                new Shoe("Loafers", "Gucci", 8, 200.0, true),
                new Shoe("Dress Shoes", "Calvin Klein", 9, 150.0, false),
                new Shoe("Sandals", "Birkenstock", 7, 60.0, true)
            })
        };

            // Muestras las opciones de tienda.
            Console.WriteLine("Elige Una Tienda:");
            for (int i = 0; i < stores.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, stores[i].name);
            }

            // Obtiene lo que el usuario ingresa
            int storeIndex = int.Parse(Console.ReadLine()) - 1;

            // Muestra el catalogo para seleccionar tiendas.
            stores[storeIndex].PrintCatalog();
            Console.ReadKey();
        }
    }

}

