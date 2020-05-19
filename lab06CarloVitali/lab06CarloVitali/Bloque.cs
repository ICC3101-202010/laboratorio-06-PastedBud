using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    [Serializable]
    public class Bloque: Division
    {
        private string nombre;

        public Bloque()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
