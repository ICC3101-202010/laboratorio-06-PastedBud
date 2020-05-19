using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    [Serializable]
    public class Seccion:Division
    {
        private string nombre;
        public List<Bloque> bloques = new List<Bloque>();

        public string Nombre { get => nombre; set => nombre = value; }

        public Seccion()
        {
        }
    }
}
