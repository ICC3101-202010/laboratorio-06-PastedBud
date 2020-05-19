using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    [Serializable]
    public class Area: Division
    {
        private string nombre;
        public List<Departamento> departamentos = new List<Departamento>();
        public Area()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
