using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    [Serializable]
    public class Empresa
    {
        private string nombre;
        private string rut;
        public List<Division> divisiones;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }

        public Empresa()
        {
            this.Nombre = Nombre;
            this.Rut = Rut;
        }
    }
}
