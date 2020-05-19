using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab06CarloVitali
{
    public class Metodos_Estaticos
    {

        private List<Empresa> empresas = new List<Empresa>();

        public List<Empresa> Empresas { get => empresas; set => empresas = value; }

        public static void Serializar_Info_Empresa(Empresa empresa)
        {


            
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
            
            /*string descripcion = registro.AddEmpresa(new List<string> { empresa.Nombre, empresa.Rut });
            if (descripcion == null)
            {*/
            


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
            Stream stream8 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter8.Serialize(stream8, persona2);
            stream8.Close();

            IFormatter formatter9 = new BinaryFormatter();
            Stream stream9 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter9.Serialize(stream9, persona3);
            stream9.Close();

            IFormatter formatter10 = new BinaryFormatter();
            Stream stream10 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter10.Serialize(stream10, persona4);
            stream10.Close();

            IFormatter formatter11 = new BinaryFormatter();
            Stream stream11 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter11.Serialize(stream11, persona5);
            stream11.Close();

            IFormatter formatter12 = new BinaryFormatter();
            Stream stream12 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter12.Serialize(stream12, persona6);
            stream12.Close();

            IFormatter formatter13 = new BinaryFormatter();
            Stream stream13 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter13.Serialize(stream13, persona7);
            stream13.Close();

            IFormatter formatter14 = new BinaryFormatter();
            Stream stream14 = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter14.Serialize(stream14, persona8);
            stream14.Close();

            
            Console.WriteLine("Se ha Registrado la Informacion de " + empresa.Nombre + "!");
        }

        public static void Deserializar_a_Instancia()
        {
            
            {
                
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Empresa empresa = formatter.Deserialize(stream) as Empresa;
                stream.Close();
                Console.WriteLine(empresa.Nombre);
                IFormatter formatter1 = new BinaryFormatter();
                Stream stream1 = new FileStream("area.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Area area1 = formatter1.Deserialize(stream1) as Area;
                stream1.Close();
                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("departamento.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Departamento departamento1 = formatter2.Deserialize(stream2) as Departamento;
                stream2.Close();
                IFormatter formatter3 = new BinaryFormatter();
                Stream stream3 = new FileStream("seccion.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Seccion seccion1 = formatter3.Deserialize(stream3) as Seccion;
                stream3.Close();
                IFormatter formatter4 = new BinaryFormatter();
                Stream stream4 = new FileStream("bloque1.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Bloque bloque1 = formatter4.Deserialize(stream4) as Bloque;
                stream4.Close();
                IFormatter formatter5 = new BinaryFormatter();
                Stream stream5 = new FileStream("bloque2.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Bloque bloque2 = formatter5.Deserialize(stream5) as Bloque;
                stream5.Close();
                IFormatter formatter6 = new BinaryFormatter();
                Stream stream6 = new FileStream("division.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Division division1 = formatter6.Deserialize(stream6) as Division;
                stream6.Close();

                IFormatter formatter7 = new BinaryFormatter();
                Stream stream7 = new FileStream("persona1.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Persona persona1 = formatter7.Deserialize(stream7) as Persona;
                stream7.Close();
                IFormatter formatter8 = new BinaryFormatter();
                Stream stream8 = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Persona persona2 = formatter8.Deserialize(stream8) as Persona;
                stream8.Close();
                IFormatter formatter9 = new BinaryFormatter();
                Stream stream9 = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Persona persona3 = formatter9.Deserialize(stream9) as Persona;
                stream9.Close();
                IFormatter formatter10 = new BinaryFormatter();
                Stream stream10 = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Persona persona4 = formatter10.Deserialize(stream10) as Persona;
                stream10.Close();
                IFormatter formatter11 = new BinaryFormatter();
                Stream stream11 = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Persona persona5 = formatter11.Deserialize(stream11) as Persona;
                stream11.Close();
                IFormatter formatter12 = new BinaryFormatter();
                Stream stream12 = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Persona persona6 = formatter12.Deserialize(stream12) as Persona;
                stream12.Close();
                IFormatter formatter13 = new BinaryFormatter();
                Stream stream13 = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Persona persona7 = formatter13.Deserialize(stream13) as Persona;
                stream13.Close();
                IFormatter formatter14 = new BinaryFormatter();
                Stream stream14 = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Persona persona8 = formatter14.Deserialize(stream14) as Persona;
                stream14.Close();


                empresa.divisiones.Add(division1);
                division1.areas.Add(area1);
                area1.departamentos.Add(departamento1);
                departamento1.secciones.Add(seccion1);
                seccion1.bloques.Add(bloque1);
                seccion1.bloques.Add(bloque2);
                division1.personas.Add(persona1);
                division1.personas.Add(persona2);
                division1.personas.Add(persona3);
                division1.personas.Add(persona4);
                division1.personas.Add(persona5);
                division1.personas.Add(persona6);
                division1.personas.Add(persona7);
                division1.personas.Add(persona8);

                //registro.AddEmpresa(new List<string> { empresa.Nombre, empresa.Rut });

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
                                                    Console.WriteLine("El Bloque: " + bloque.Nombre);
                                                    foreach (Persona persona in division.personas)
                                                    {
                                                        if (persona.Cargo[1] == "Jefe")
                                                        {
                                                            if (persona.Cargo[0] == bloque.Nombre)
                                                            {
                                                                Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                            }
                                                        }
                                                    }
                                                    Console.WriteLine("Con trabajadores: ");
                                                    Console.WriteLine("");
                                                    foreach (Persona persona in division.personas)
                                                    {
                                                        if (persona.Cargo[1] != "Jefe")
                                                        {
                                                            if (persona.Cargo[0] == bloque.Nombre)
                                                            {
                                                                Console.WriteLine("Nombre: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("La Seccion: " + seccion.Nombre);
                                                foreach (Persona persona in division.personas)
                                                {
                                                    if (persona.Cargo[1] == "Jefe")
                                                    {
                                                        if (persona.Cargo[0] == seccion.Nombre)
                                                        {
                                                            Console.WriteLine("Con Jefe de Seccion: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                        }
                                                    }
                                                }
                                                foreach (Bloque bloque in seccion.bloques)
                                                {
                                                    Console.WriteLine("El Bloque: " + bloque.Nombre);
                                                    foreach (Persona persona in division.personas)
                                                    {
                                                        if (persona.Cargo[1] == "Jefe")
                                                        {
                                                            if (persona.Cargo[0] == bloque.Nombre)
                                                            {
                                                                Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                            }
                                                        }
                                                    }
                                                    Console.WriteLine("Con trabajadores: ");
                                                    Console.WriteLine("");
                                                    foreach (Persona persona in division.personas)
                                                    {
                                                        if (persona.Cargo[1] != "Jefe")
                                                        {
                                                            if (persona.Cargo[0] == bloque.Nombre)
                                                            {
                                                                Console.WriteLine("Nombre: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El Departamento: " + departamento.Nombre);
                                        foreach (Persona persona in division.personas)
                                        {
                                            if (persona.Cargo[1] == "Jefe")
                                            {
                                                if (persona.Cargo[0] == departamento.Nombre)
                                                {
                                                    Console.WriteLine("Con Jefe de Departamento: " + persona.Nombre + persona.Apellido + "        Rut: " + persona.Rut);
                                                }
                                            }
                                        }
                                        foreach (Seccion seccion in departamento.secciones)
                                        {
                                            Console.WriteLine("La Seccion: " + seccion.Nombre);
                                            foreach (Persona persona in division.personas)
                                            {
                                                if (persona.Cargo[1] == "Jefe")
                                                {
                                                    if (persona.Cargo[0] == seccion.Nombre)
                                                    {
                                                        Console.WriteLine("Con Jefe de Seccion: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                    }
                                                }
                                            }
                                            foreach (Bloque bloque in seccion.bloques)
                                            {
                                                Console.WriteLine("El Bloque: " + bloque.Nombre);
                                                foreach (Persona persona in division.personas)
                                                {
                                                    if (persona.Cargo[1] == "Jefe")
                                                    {
                                                        if (persona.Cargo[0] == bloque.Nombre)
                                                        {
                                                            Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                        }
                                                    }
                                                }
                                                Console.WriteLine("Con trabajadores: ");
                                                Console.WriteLine("");
                                                foreach (Persona persona in division.personas)
                                                {
                                                    if (persona.Cargo[1] != "Jefe")
                                                    {
                                                        if (persona.Cargo[0] == bloque.Nombre)
                                                        {
                                                            Console.WriteLine("Nombre: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
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
                                Console.WriteLine("El Area: " + area.Nombre);
                                foreach (Persona persona in division.personas)
                                {
                                    if (persona.Cargo[1] == "Jefe")
                                    {
                                        if (persona.Cargo[0] == area.Nombre)
                                        {
                                            Console.WriteLine("Con Jefe de Area: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                        }
                                    }
                                }
                                foreach (Departamento departamento in area.departamentos)
                                {
                                    Console.WriteLine("El Departamento: " + departamento.Nombre);
                                    foreach (Persona persona in division.personas)
                                    {
                                        if (persona.Cargo[1] == "Jefe")
                                        {
                                            if (persona.Cargo[0] == departamento.Nombre)
                                            {
                                                Console.WriteLine("Con Jefe de Departamento: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                            }
                                        }
                                    }
                                    foreach (Seccion seccion in departamento.secciones)
                                    {
                                        Console.WriteLine("La Seccion: " + seccion.Nombre);
                                        foreach (Persona persona in division.personas)
                                        {
                                            if (persona.Cargo[1] == "Jefe")
                                            {
                                                if (persona.Cargo[0] == seccion.Nombre)
                                                {
                                                    Console.WriteLine("Con Jefe de Seccion: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                }
                                            }
                                        }
                                        foreach (Bloque bloque in seccion.bloques)
                                        {
                                            Console.WriteLine("El Bloque: " + bloque.Nombre);
                                            foreach (Persona persona in division.personas)
                                            {
                                                if (persona.Cargo[1] == "Jefe")
                                                {
                                                    if (persona.Cargo[0] == bloque.Nombre)
                                                    {
                                                        Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                    }
                                                }
                                            }
                                            Console.WriteLine("Con trabajadores: ");
                                            Console.WriteLine("");
                                            foreach (Persona persona in division.personas)
                                            {
                                                if (persona.Cargo[1] != "Jefe")
                                                {
                                                    if (persona.Cargo[0] == bloque.Nombre)
                                                    {
                                                        Console.WriteLine("Nombre: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
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
                        Console.WriteLine("La division: " + division.Nombre);
                        foreach (Persona persona in division.personas)
                        {
                            if (persona.Cargo[1] == "Jefe")
                            {
                                if (persona.Cargo[0] == division.Nombre)
                                {
                                    Console.WriteLine("Con Jefe de Division: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                }
                            }
                        }

                        foreach (Area area in division.areas)
                        {
                            Console.WriteLine("El Area: " + area.Nombre);
                            foreach (Persona persona in division.personas)
                            {
                                if (persona.Cargo[1] == "Jefe")
                                {
                                    if (persona.Cargo[0] == area.Nombre)
                                    {
                                        Console.WriteLine("Con Jefe de Area: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                    }
                                }
                            }
                            foreach (Departamento departamento in area.departamentos)
                            {
                                Console.WriteLine("El Departamento: " + departamento.Nombre);
                                foreach (Persona persona in division.personas)
                                {
                                    if (persona.Cargo[1] == "Jefe")
                                    {
                                        if (persona.Cargo[0] == departamento.Nombre)
                                        {
                                            Console.WriteLine("Con Jefe de Departamento: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                        }
                                    }
                                }
                                foreach (Seccion seccion in departamento.secciones)
                                {
                                    Console.WriteLine("La Seccion: " + seccion.Nombre);
                                    foreach (Persona persona in division.personas)
                                    {
                                        if (persona.Cargo[1] == "Jefe")
                                        {
                                            if (persona.Cargo[0] == seccion.Nombre)
                                            {
                                                Console.WriteLine("Con Jefe de Seccion: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                            }
                                        }
                                    }
                                    foreach (Bloque bloque in seccion.bloques)
                                    {
                                        Console.WriteLine("El Bloque: " + bloque.Nombre);
                                        foreach (Persona persona in division.personas)
                                        {
                                            if (persona.Cargo[1] == "Jefe")
                                            {
                                                if (persona.Cargo[0] == bloque.Nombre)
                                                {
                                                    Console.WriteLine("Con Jefe de Bloque: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
                                                }
                                            }
                                        }
                                        Console.WriteLine("Con trabajadores: ");
                                        Console.WriteLine("");
                                        foreach (Persona persona in division.personas)
                                        {
                                            if (persona.Cargo[1] != "Jefe")
                                            {
                                                if (persona.Cargo[0] == bloque.Nombre)
                                                {
                                                    Console.WriteLine("Nombre: " + persona.Nombre + persona.Apellido + "Rut: " + persona.Rut);
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
            /*catch (Exception ex)
            {
                
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Empresa empresa = (Empresa)formatter.Deserialize(stream);
                stream.Close();
                Serializar_Info_Empresa(empresa);
            }*/
        }
    }
}
