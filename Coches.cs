using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concesionario
{
    class Coches
    {
        String marca;
        String modelo;
        String version;
        String combustible;
        String precio;
        Extras extras;

        public Coches(string marca, string modelo, string version, string combustible, string precio, Extras extras)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.version = version;
            this.combustible = combustible;
            this.precio = precio;
            this.extras = extras;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Version { get => version; set => version = value; }
        public string Combustible { get => combustible; set => combustible = value; }
        public string Precio { get => precio; set => precio = value; }
        public Extras Extras { get => extras; set => extras = value; }
    }
}
