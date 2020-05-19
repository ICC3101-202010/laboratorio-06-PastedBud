using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    [Serializable]
    public class Division
    {
        private string nombre;
        public List<Area> areas = new List<Area>();
        public List<Persona> personas = new List<Persona>();
        public Division()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
