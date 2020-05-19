using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    [Serializable]
    public static class Metodos_Estaticos
    {
        public static void Serializar_Info_Empresa(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
            Console.WriteLine("Se ha Registrado la Informacion de " + empresa.Nombre + "!");
        }
        public static void Deserializar_a_Instancia()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Empresa empresa = (Empresa)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Se ha cargado la Informacion de " + empresa.Nombre + "!");

            Console.WriteLine("El Rut de la Empresa es: " + empresa.Rut);


            Console.WriteLine(empresa.Nombre + " se compone de: ");
            Console.WriteLine("");



            foreach (Division division in empresa.divisiones)
            {
                if (division.Nombre == "")
                {
                    foreach (Area area in division.areas)
                    {
                        if (area.Nombre == "")
                        {
                            foreach (Departamento departamento in area.departamentos)
                            {
                                if (departamento.Nombre == "")
                                {
                                    foreach (Seccion seccion in departamento.secciones)
                                    {
                                        if (seccion.Nombre == "")
                                        {
                                            foreach (Bloque bloque in seccion.bloques)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("El Bloque: " + bloque.Nombre);
                                                foreach (Persona persona in division.personas)
                                                {
                                                    if (persona.Cargo == "Jefe")
                                                    {
                                                        if (persona.Subdivision == bloque.Nombre)
                                                        {
                                                            Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                        }
                                                    }
                                                }
                                                Console.WriteLine("Con trabajadores: ");
                                                Console.WriteLine("");
                                                foreach (Persona persona in division.personas)
                                                {
                                                    if (persona.Cargo != "Jefe")
                                                    {
                                                        if (persona.Subdivision == bloque.Nombre)
                                                        {
                                                            Console.WriteLine("Nombre: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("La Seccion: " + seccion.Nombre);
                                            foreach (Persona persona in division.personas)
                                            {
                                                if (persona.Cargo == "Jefe")
                                                {
                                                    if (persona.Subdivision == seccion.Nombre)
                                                    {
                                                        Console.WriteLine("Con Jefe de Seccion: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                    }
                                                }
                                            }
                                            foreach (Bloque bloque in seccion.bloques)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("El Bloque: " + bloque.Nombre);
                                                foreach (Persona persona in division.personas)
                                                {
                                                    if (persona.Cargo == "Jefe")
                                                    {
                                                        if (persona.Subdivision == bloque.Nombre)
                                                        {
                                                            Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                        }
                                                    }
                                                }
                                                Console.WriteLine("Con trabajadores: ");
                                                Console.WriteLine("");
                                                foreach (Persona persona in division.personas)
                                                {
                                                    if (persona.Cargo != "Jefe")
                                                    {
                                                        if (persona.Subdivision == bloque.Nombre)
                                                        {
                                                            Console.WriteLine("Nombre: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("El Departamento: " + departamento.Nombre);
                                    foreach (Persona persona in division.personas)
                                    {
                                        if (persona.Cargo == "Jefe")
                                        {
                                            if (persona.Subdivision == departamento.Nombre)
                                            {
                                                Console.WriteLine("Con Jefe de Departamento: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                            }
                                        }
                                    }
                                    foreach (Seccion seccion in departamento.secciones)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("La Seccion: " + seccion.Nombre);
                                        foreach (Persona persona in division.personas)
                                        {
                                            if (persona.Cargo == "Jefe")
                                            {
                                                if (persona.Subdivision == seccion.Nombre)
                                                {
                                                    Console.WriteLine("Con Jefe de Seccion: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                }
                                            }
                                        }
                                        foreach (Bloque bloque in seccion.bloques)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("El Bloque: " + bloque.Nombre);
                                            foreach (Persona persona in division.personas)
                                            {
                                                if (persona.Cargo == "Jefe")
                                                {
                                                    if (persona.Subdivision == bloque.Nombre)
                                                    {
                                                        Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                    }
                                                }
                                            }
                                            Console.WriteLine("Con trabajadores: ");
                                            Console.WriteLine("");
                                            foreach (Persona persona in division.personas)
                                            {
                                                if (persona.Cargo != "Jefe")
                                                {
                                                    if (persona.Subdivision == bloque.Nombre)
                                                    {
                                                        Console.WriteLine("Nombre: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("El Area: " + area.Nombre);
                            foreach (Persona persona in division.personas)
                            {
                                if (persona.Cargo == "Jefe")
                                {
                                    if (persona.Subdivision == area.Nombre)
                                    {
                                        Console.WriteLine("Con Jefe de Area: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                    }
                                }
                            }
                            foreach (Departamento departamento in area.departamentos)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("El Departamento: " + departamento.Nombre);
                                foreach (Persona persona in division.personas)
                                {
                                    if (persona.Cargo == "Jefe")
                                    {
                                        if (persona.Subdivision == departamento.Nombre)
                                        {
                                            Console.WriteLine("Con Jefe de Departamento: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                        }
                                    }
                                }
                                foreach (Seccion seccion in departamento.secciones)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("La Seccion: " + seccion.Nombre);
                                    foreach (Persona persona in division.personas)
                                    {
                                        if (persona.Cargo == "Jefe")
                                        {
                                            if (persona.Subdivision == seccion.Nombre)
                                            {
                                                Console.WriteLine("Con Jefe de Seccion: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                            }
                                        }
                                    }
                                    foreach (Bloque bloque in seccion.bloques)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("El Bloque: " + bloque.Nombre);
                                        foreach (Persona persona in division.personas)
                                        {
                                            if (persona.Cargo == "Jefe")
                                            {
                                                if (persona.Subdivision == bloque.Nombre)
                                                {
                                                    Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                }
                                            }
                                        }
                                        Console.WriteLine("Con trabajadores: ");
                                        Console.WriteLine("");
                                        foreach (Persona persona in division.personas)
                                        {
                                            if (persona.Cargo != "Jefe")
                                            {
                                                if (persona.Subdivision == bloque.Nombre)
                                                {
                                                    Console.WriteLine("Nombre: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("La division: " + division.Nombre);
                    foreach (Persona persona in division.personas)
                    {
                        if (persona.Cargo == "Jefe")
                        {
                            if (persona.Subdivision == division.Nombre)
                            {
                                Console.WriteLine("Con Jefe de Division: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                            }
                        }
                    }

                    foreach (Area area in division.areas)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("El Area: " + area.Nombre);
                        foreach (Persona persona in division.personas)
                        {
                            if (persona.Cargo == "Jefe")
                            {
                                if (persona.Subdivision == area.Nombre)
                                {
                                    Console.WriteLine("Con Jefe de Area: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                }
                            }
                        }
                        foreach (Departamento departamento in area.departamentos)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("El Departamento: " + departamento.Nombre);
                            foreach (Persona persona in division.personas)
                            {
                                if (persona.Cargo == "Jefe")
                                {
                                    if (persona.Subdivision == departamento.Nombre)
                                    {
                                        Console.WriteLine("Con Jefe de Departamento: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                    }
                                }
                            }
                            foreach (Seccion seccion in departamento.secciones)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("La Seccion: " + seccion.Nombre);
                                foreach (Persona persona in division.personas)
                                {
                                    if (persona.Cargo == "Jefe")
                                    {
                                        if (persona.Subdivision == seccion.Nombre)
                                        {
                                            Console.WriteLine("Con Jefe de Seccion: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                        }
                                    }
                                }
                                foreach (Bloque bloque in seccion.bloques)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("El Bloque: " + bloque.Nombre);
                                    foreach (Persona persona in division.personas)
                                    {
                                        if (persona.Cargo == "Jefe")
                                        {
                                            if (persona.Subdivision == bloque.Nombre)
                                            {
                                                Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                            }
                                        }
                                    }
                                    Console.WriteLine("Con trabajadores: ");

                                    foreach (Persona persona in division.personas)
                                    {
                                        if (persona.Cargo != "Jefe")
                                        {
                                            if (persona.Subdivision == bloque.Nombre)
                                            {
                                                Console.WriteLine("Nombre: " + persona.Nombre + " " + persona.Apellido + "        Rut: " + persona.Rut);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }


        }

    }
}
