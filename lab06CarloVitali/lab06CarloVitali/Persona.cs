using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string rut;
        private string cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public Persona()
        {
        }
    }
}
