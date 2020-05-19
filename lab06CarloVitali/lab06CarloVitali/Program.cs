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


            int a = 1;
            while (a == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Quiere utilizar un archivo para cargar la información de la empresa?");
                Console.WriteLine("");
                Console.WriteLine("1 --> Si");
                Console.WriteLine("2 --> No");
                Console.WriteLine("3 --> Salir");
                string utilizar_archivo = Console.ReadLine();

                if (utilizar_archivo == "1")
                {


                    try
                    {
                        Metodos_Estaticos.Deserializar_a_Instancia();
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine("No se encontro el archivo de la Empresa");
                        Console.WriteLine("");
                        Empresa empresa = new Empresa();
                        Console.WriteLine("Ingrese el Nombre de su Empresa: ");
                        Console.WriteLine("");
                        empresa.Nombre = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el rut de su Empresa: ");
                        Console.WriteLine("");
                        empresa.Rut = Console.ReadLine();
                        Console.WriteLine("");


                        Division division = new Division();
                        division.Nombre = "";
                        Area area = new Area();
                        area.Nombre = "";
                        Departamento departamento = new Departamento();
                        departamento.Nombre = "Direccion";
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
                        persona1.Subdivision = "Direccion";
                        persona1.Cargo = "Jefe";
                        division.personas.Add(persona1);
                        Persona persona2 = new Persona();
                        persona2.Nombre = "Pascale";
                        persona2.Apellido = "Butron";
                        persona2.Rut = "2";
                        persona2.Subdivision = "Marketing";
                        persona2.Cargo = "Jefe";
                        division.personas.Add(persona2);
                        Persona persona3 = new Persona();
                        persona3.Nombre = "Cristobal";
                        persona3.Apellido = "Fierro";
                        persona3.Rut = "3";
                        persona3.Subdivision = "Ventas";
                        persona3.Cargo = "Jefe";
                        division.personas.Add(persona3);
                        Persona persona4 = new Persona();
                        persona4.Nombre = "Fernando";
                        persona4.Apellido = "Manzano";
                        persona4.Rut = "4";
                        persona4.Subdivision = "Publicidad";
                        persona4.Cargo = "Jefe";
                        division.personas.Add(persona4);
                        Persona persona5 = new Persona();
                        persona5.Nombre = "Augusto";
                        persona5.Apellido = "Pesci";
                        persona5.Rut = "5";
                        persona5.Subdivision = "Publicidad";
                        persona5.Cargo = "Trabajador";
                        division.personas.Add(persona5);
                        Persona persona6 = new Persona();
                        persona6.Nombre = "Nicolas";
                        persona6.Apellido = "Pisani";
                        persona6.Rut = "6";
                        persona6.Subdivision = "Publicidad";
                        persona6.Cargo = "Trabajador";
                        division.personas.Add(persona6);
                        Persona persona7 = new Persona();
                        persona7.Nombre = "Manuel";
                        persona7.Apellido = "Gonzalez";
                        persona7.Rut = "7";
                        persona7.Subdivision = "Ventas";
                        persona7.Cargo = "Trabajador";
                        division.personas.Add(persona7);
                        Persona persona8 = new Persona();
                        persona8.Nombre = "Luciano";
                        persona8.Apellido = "Villagran";
                        persona8.Rut = "8";
                        persona8.Subdivision = "Ventas";
                        persona8.Cargo = "Trabajador";
                        division.personas.Add(persona8);
                        empresa.divisiones.Add(division);
                        division.areas.Add(area);
                        area.departamentos.Add(departamento);
                        departamento.secciones.Add(seccion);
                        seccion.bloques.Add(bloque1);
                        seccion.bloques.Add(bloque2);


                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, empresa);
                        stream.Close();

                        Console.WriteLine("Se ha Registrado la Informacion de " + empresa.Nombre + "!");
                        Console.WriteLine("");

                        Metodos_Estaticos.Deserializar_a_Instancia();




                    }
                    a = 1;
                }
                else if (utilizar_archivo == "2")
                {

                    Empresa empresa = new Empresa();
                    Console.WriteLine("Ingrese el Nombre de su Empresa: ");
                    empresa.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut de su Empresa: ");
                    empresa.Rut = Console.ReadLine();


                    Metodos_Estaticos.Serializar_Info_Empresa(empresa);



                    a = 1;







                }
                else if (utilizar_archivo == "3")
                {
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
