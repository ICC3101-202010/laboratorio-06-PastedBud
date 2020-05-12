using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace lab06CarloVitali
{
    [Serializable]
    public class Registro_Empresas
    {
        private Dictionary<int, List<string>> Data_Empresas;
        public Registro_Empresas()
        {
        }
        public Dictionary<int, List<string>> Data_Empresas1 { get => Data_Empresas; set => Data_Empresas = value; }

        public string AddEmpresa(List<string> data)
        {
            string descripcion = null;
            foreach (List<string> value in this.Data_Empresas.Values)
            {
                if (data[0] == value[0])
                {
                    descripcion = "El nombre de la empresa especificada ya existe";
                }
                else if (data[1] == value[1])
                {
                    descripcion = "El Rut ingresado ya esta sujeto a otra empresa";
                }
            }
            if (descripcion == null)
            {
                this.Data_Empresas.Add(Data_Empresas.Count + 1, data);
                
            }
            return descripcion;
        }
    }
}
