using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aves
{
    class Ave
    { 
        //Se crea una lista con sus Get y Set
        List<Avv> avesArr = new List<Avv>();
        //Metodo Menu donde se muestan las opcioes p
        public void Menu()
        {
            int option; 
            System.Console.WriteLine("\n");
            System.Console.WriteLine("###########################################");
            System.Console.WriteLine("######## ---- Sistema de Aves ---- ########");
            System.Console.WriteLine( "Total de observaciones - "+TotalObservaciones() );
            System.Console.WriteLine("1. Agregar Observación.");
            System.Console.WriteLine("2. Ver Observaciónes.");
            System.Console.WriteLine("3. Buscar observaciones por lugar");
            System.Console.WriteLine("4. Buscar observaciones por tipo de ave"); 
            System.Console.WriteLine("5. Salir del sistema.");
            System.Console.WriteLine("###########################################\n");
            System.Console.Write("Seleccione una opción (1 - 5): "); 
            option = int.Parse(System.Console.ReadLine());
            //Depende de la opcion seleccionada se accede a un metodo
            switch (option)
            {
                case 1:
                    System.Console.Clear();
                    System.Console.WriteLine("Ingrese tipo del Ave observada");
                    System.Console.WriteLine("Opciones: ");
                    System.Console.WriteLine("- Corredoras");
                    System.Console.WriteLine("- De Vuelo");
                    System.Console.WriteLine("- Rapaces");
                    System.Console.WriteLine("- Etc");
                    //Pedimos que el usuario ingrese un dato tipo texto
                    string tipo = (System.Console.ReadLine());
                    System.Console.WriteLine("###########################################");
                    System.Console.WriteLine("Ingrese fecha de la observación");
                    System.Console.WriteLine("Formato:  '11-07-2022'");
                    string fecha = (System.Console.ReadLine());
                    System.Console.WriteLine("###########################################");
                    System.Console.WriteLine("Ingrese localización de la observación");
                    string localizacion = (System.Console.ReadLine());
                    System.Console.WriteLine("###########################################");
                    System.Console.WriteLine("Ingrese nombre del pájaro observado");
                    System.Console.WriteLine("-Águila\n-Pato,\n-Tucan\n- etc.");
                    string nombre = (System.Console.ReadLine());
                    //Enviamos la data al metodo para su agregacion a la lista
                    agregarAve(tipo, fecha, localizacion, nombre);

                    break;
                case 2:
                    VerAves();
                    break;
                case 3:
                    buscarPorLocalidad();
                    break;
                case 4:
                    buscarPorTipoDeAve();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.Clear(); 
                    System.Console.WriteLine("Seleccione una opción correcta.");
                    Menu();
                    break;
            }
             
        }

        public void agregarAve(String txttipo, String txtfecha, String txtlocalizacion, String txtnombre)
        { 
            //limpiamos la consola
            System.Console.Clear();
            //mandamos la data a la lista 
            avesArr.Add(new Avv { tipo = txttipo, fecha = txtfecha, localizacion = txtlocalizacion, nombre = txtnombre });
            System.Console.WriteLine("Se agrego la observación");
            Menu();
        }

        public void VerAves()
        {
            System.Console.Clear();
            System.Console.WriteLine("###########################################");
            System.Console.WriteLine("       ---- Lista de observaciones ----    ");
            int count = 1;
            //iteramos la lista para mostrar datos ordenadamente
            foreach (var ave in avesArr)
            {
                System.Console.WriteLine(count + " -  Tipo " + ave.tipo + " - Fecha " + ave.fecha + " - Loc " + ave.localizacion + " - Nombre " + ave.nombre);
                count = count + 1; //contador para dar indice nada mas :)
            }
            System.Console.WriteLine("###########################################\n\n");
            Menu();
        }
        public int TotalObservaciones()
        { 
            int count = 0;
            foreach (var ave in avesArr)
            { 
                count = count + 1;
            }
            return count;
        }

        public void buscarPorLocalidad()
        {
            System.Console.Clear();
            System.Console.WriteLine("###########################################");
            System.Console.WriteLine("     ---- Buscar por lugares ----    ");
            System.Console.WriteLine("     ---- Seleccione lugar ----    ");
            int count = 1;
            foreach (var ave in avesArr)
            {
                System.Console.WriteLine(ave.localizacion);
                count = count + 1;
            }
            System.Console.WriteLine("###########################################\n\n");

            System.Console.WriteLine("Ingrese lugar");
            string lugar = (System.Console.ReadLine());
            count = 1;
            foreach (var ave in avesArr)
            {
                //Buscamos las coincidencias de busqueda
                if (lugar == ave.localizacion)
                {
                    System.Console.WriteLine(count + " -  Tipo " + ave.tipo + " - Fecha " + ave.fecha + " - Loc " + ave.localizacion + " - Nombre " + ave.nombre);
                    count = count + 1;
                } 
            }
            Menu();
        }

        public void buscarPorTipoDeAve()
        {
            System.Console.Clear();
            System.Console.WriteLine("###########################################");
            System.Console.WriteLine("     ---- Buscar por tipos de aves ----    ");
            System.Console.WriteLine("     ---- Seleccione tipos de aves ----    ");
            int count = 1;
            foreach (var ave in avesArr)
            {
                System.Console.WriteLine(ave.tipo);
                count = count + 1;
            }
            System.Console.WriteLine("###########################################\n\n");

            System.Console.WriteLine("Ingrese Tipos");
            string tipo = (System.Console.ReadLine());
            count = 1;
            foreach (var ave in avesArr)
            {
                if (tipo == ave.tipo)
                {
                    System.Console.WriteLine(count + " -  Tipo " + ave.tipo + " - Fecha " + ave.fecha + " - Loc " + ave.localizacion + " - Nombre " + ave.nombre);
                    count = count + 1;
                }
            }
            Menu();
        }
    }
}
