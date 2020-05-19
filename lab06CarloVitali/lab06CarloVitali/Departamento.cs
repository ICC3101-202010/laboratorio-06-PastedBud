using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    [Serializable]
    public class Departamento: Division
    {
        private string nombre;
        public List<Seccion> secciones = new List<Seccion>();

        public string Nombre { get => nombre; set => nombre = value; }

        public Departamento()
        {
        }
    }
}
