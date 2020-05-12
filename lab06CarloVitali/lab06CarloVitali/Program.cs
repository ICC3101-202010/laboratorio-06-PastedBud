using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Empresa> empresas = new List<Empresa>();
            Dictionary<int, List<string>> Registro_Empresas= new Dictionary<int, List<string>>();
            Registro_Empresas registro = new Registro_Empresas();
            int a = 1;
            while (a == 1)
            {
                Console.WriteLine("Quiere utilizar un archivo para cargar la información de la empresa?");
                Console.WriteLine("");
                Console.WriteLine("1 --> Si");
                Console.WriteLine("2 --> No");
                int utilizar_archivo = Convert.ToInt32(Console.ReadLine());

                if (utilizar_archivo == 1)
                {
                    
                    
                    try
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Empresa empresa = (Empresa)formatter.Deserialize(stream);
                        stream.Close();
                        empresas.Add(empresa);
                        //registro.AddEmpresa(new List<string> { empresa.Nombre, empresa.Rut });

                        Console.WriteLine("Se ha cargado la Informacion de "+ empresa.Nombre+ "!");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("No se encontro el archivo de la Empresa");
                        Console.WriteLine("");
                        Empresa empresa = new Empresa();
                        Console.WriteLine("Ingrese el Nombre de su Empresa: ");
                        empresa.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut de su Empresa: ");
                        empresa.Rut = Console.ReadLine();
                        empresas.Add(empresa);
                        /*string descripcion = registro.AddEmpresa(new List<string> { empresa.Nombre, empresa.Rut });
                        if (descripcion == null)
                        {*/
                            IFormatter formatter = new BinaryFormatter();
                            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter.Serialize(stream, empresa);
                            stream.Close();
                        /*}
                        else
                        {
                            Console.WriteLine(descripcion);
                        }*/
                    }
                    a = 0;
                }
                else if (utilizar_archivo == 2)
                {
                    Empresa empresa = new Empresa();
                    Console.WriteLine("Ingrese el Nombre de su Empresa: ");
                    empresa.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut de su Empresa: ");
                    empresa.Rut = Console.ReadLine();
                    empresas.Add(empresa);
                    //string descripcion = registro.AddEmpresa(new List<string> { empresa.Nombre, empresa.Rut});
                    //if (descripcion == null)
                    //{
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, empresa);
                        stream.Close();
                    /*}
                    else
                    {
                        Console.WriteLine(descripcion);
                    }*/
                    a = 0;
                }
                else
                {
                    Console.WriteLine("Opcion Invalida");
                    a = 1;
                }
            }
            
        }
    }
}
