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
            
            Dictionary<int, List<string>> Registro_Empresas= new Dictionary<int, List<string>>();
            Registro_Empresas registro = new Registro_Empresas();
            Metodos_Estaticos metodos = new Metodos_Estaticos();
            
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
                        Metodos_Estaticos.Deserializar_a_Instancia();


                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine("No se encontro el archivo de la Empresa");
                        Console.WriteLine("");
                        
                        Console.WriteLine("Ingrese el Nombre de su Empresa: ");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut de su Empresa: ");
                        string Rut = Console.ReadLine();
                        Empresa empresa = new Empresa(Nombre, Rut);
                        Division division = new Division();
                        division.Nombre = "";
                        Area area = new Area();
                        area.Nombre = "";
                        Departamento departamento = new Departamento();
                        departamento.Nombre = "Gerencia";
                        Seccion seccion = new Seccion();
                        seccion.Nombre = "Marketing";
                        Bloque bloque1 = new Bloque();
                        Bloque bloque2 = new Bloque();
                        bloque1.Nombre = "Ventas";
                        bloque2.Nombre = "Publicidad";
                        Persona persona1 = new Persona();
                        persona1.Nombre = "Carlo";
                        persona1.Apellido = "Vitali";
                        persona1.Rut = "1";
                        persona1.Cargo.Add("Direccion");
                        persona1.Cargo.Add("Jefe");
                        division.personas.Add(persona1);
                        Persona persona2 = new Persona();
                        persona2.Nombre = "Pascale";
                        persona2.Apellido = "Butron";
                        persona2.Rut = "2";
                        persona2.Cargo.Add("Marketing");
                        persona2.Cargo.Add("Jefe");
                        division.personas.Add(persona2);
                        Persona persona3 = new Persona();
                        persona3.Nombre = "Cristobal";
                        persona3.Apellido = "Fierro";
                        persona3.Rut = "3";
                        persona3.Cargo.Add("Ventas");
                        persona3.Cargo.Add("Jefe");
                        division.personas.Add(persona3);
                        Persona persona4 = new Persona();
                        persona4.Nombre = "Fernando";
                        persona4.Apellido = "Manzano";
                        persona4.Rut = "4";
                        persona4.Cargo.Add("Publicidad");
                        persona4.Cargo.Add("Jefe");
                        division.personas.Add(persona4);
                        Persona persona5 = new Persona();
                        persona5.Nombre = "Augusto";
                        persona5.Apellido = "Pesci";
                        persona5.Rut = "5";
                        persona5.Cargo.Add("Publicidad");
                        persona5.Cargo.Add("Trabajador");
                        Persona persona6 = new Persona();
                        persona6.Nombre = "Nicolas";
                        persona6.Apellido = "Pisani";
                        persona6.Rut = "6";
                        persona6.Cargo.Add("Publicidad");
                        persona6.Cargo.Add("Trabajador");
                        division.personas.Add(persona6);
                        Persona persona7 = new Persona();
                        persona7.Nombre = "Manuel";
                        persona7.Apellido = "Gonzalez";
                        persona7.Rut = "7";
                        persona7.Cargo.Add("Ventas");
                        persona7.Cargo.Add("Trabajador");
                        division.personas.Add(persona7);
                        Persona persona8 = new Persona();
                        persona8.Nombre = "Luciano";
                        persona8.Apellido = "Villagran";
                        persona8.Rut = "8";
                        persona8.Cargo.Add("Ventas");
                        persona8.Cargo.Add("Trabajador");
                        division.personas.Add(persona8);
                        empresa.divisiones.Add(division);
                        division.areas.Add(area);
                        area.departamentos.Add(departamento);
                        departamento.secciones.Add(seccion);
                        seccion.bloques.Add(bloque1);
                        seccion.bloques.Add(bloque2);
                        metodos.Empresas.Add(empresa);
                        /*string descripcion = registro.AddEmpresa(new List<string> { empresa.Nombre, empresa.Rut });
                        if (descripcion == null)
                        {*/
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, empresa);
                        stream.Close();


                        IFormatter formatter6 = new BinaryFormatter();
                        Stream stream6 = new FileStream("division.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter6.Serialize(stream6, division);
                        stream6.Close();

                        IFormatter formatter1 = new BinaryFormatter();
                        Stream stream1 = new FileStream("area.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter1.Serialize(stream1, area);
                        stream1.Close();

                        IFormatter formatter2 = new BinaryFormatter();
                        Stream stream2 = new FileStream("departamento.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter2.Serialize(stream2, departamento);
                        stream2.Close();

                        IFormatter formatter3 = new BinaryFormatter();
                        Stream stream3 = new FileStream("seccion.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter3.Serialize(stream3, seccion);
                        stream3.Close();

                        IFormatter formatter4 = new BinaryFormatter();
                        Stream stream4 = new FileStream("bloque1.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter4.Serialize(stream4, bloque1);
                        stream4.Close();

                        IFormatter formatter5 = new BinaryFormatter();
                        Stream stream5 = new FileStream("bloque2.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter5.Serialize(stream5, bloque2);
                        stream5.Close();

                        IFormatter formatter7 = new BinaryFormatter();
                        Stream stream7 = new FileStream("persona1.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter7.Serialize(stream7, persona1);
                        stream7.Close();

                        IFormatter formatter8 = new BinaryFormatter();
                        Stream stream8 = new FileStream("persona2.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter8.Serialize(stream8, persona2);
                        stream8.Close();

                        IFormatter formatter9 = new BinaryFormatter();
                        Stream stream9 = new FileStream("persona3.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter9.Serialize(stream9, persona3);
                        stream9.Close();

                        IFormatter formatter10 = new BinaryFormatter();
                        Stream stream10 = new FileStream("persona4.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter10.Serialize(stream10, persona4);
                        stream10.Close();

                        IFormatter formatter11 = new BinaryFormatter();
                        Stream stream11 = new FileStream("persona5.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter11.Serialize(stream11, persona5);
                        stream11.Close();

                        IFormatter formatter12 = new BinaryFormatter();
                        Stream stream12 = new FileStream("persona6.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter12.Serialize(stream12, persona6);
                        stream12.Close();

                        IFormatter formatter13 = new BinaryFormatter();
                        Stream stream13 = new FileStream("persona7.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter13.Serialize(stream13, persona7);
                        stream13.Close();

                        IFormatter formatter14 = new BinaryFormatter();
                        Stream stream14 = new FileStream("persona8.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter14.Serialize(stream14, persona8);
                        stream14.Close();

                        Console.WriteLine("Se ha Registrado la Informacion de " + empresa.Nombre + "!");
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
                    
                    
                    Console.WriteLine("Ingrese el Nombre de su Empresa: ");
                    string Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut de su Empresa: ");
                    string Rut = Console.ReadLine();
                    Empresa empresa = new Empresa(Nombre, Rut);
                    empresa.nombre = Nombre;
                    empresa.Nombre = Nombre;
                    empresa.rut = Rut;
                    empresa.Rut = Rut;
                    metodos.Empresas.Add(empresa);
                    //string descripcion = registro.AddEmpresa(new List<string> { empresa.Nombre, empresa.Rut});
                    //if (descripcion == null)
                    //{
                    
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, empresa);
                    stream.Close();
                    Metodos_Estaticos.Serializar_Info_Empresa(empresa);

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
