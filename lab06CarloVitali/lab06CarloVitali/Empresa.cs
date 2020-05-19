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
        public string nombre;
        public string rut;
        public List<Division> divisiones = new List<Division>();
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
        
        public Empresa(string Nombre , string Rut)
        {
            this.nombre = Nombre;
            this.rut = Rut;
        }
        
       
    }
}
