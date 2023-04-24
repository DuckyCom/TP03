namespace TP02BOX_CW_FE;
using System.Collections.Generic;
class Program
{
    static Dictionary<int, Cliente> Clientes = new Dictionary<int, Cliente>();
    static Tiquetera tiquetera;
    static void Main(string[] args)
    {
        int menu;
        bool Repeticion = true;
        string CalidaDespedida = "Chau";
        while(Repeticion)
        {
        menu = listaFunciones();
        limpiarConsola();
        switch (menu)
        {
            case 1:
            limpiarConsola();
                break;
            case 2:
            limpiarConsola();
                break;
            case 3:
            limpiarConsola(); 
                break;
            case 4:

                break;
            case 5:
            Console.WriteLine(CalidaDespedida);
            Repeticion = false;  
                break;
        }
        }
    }
    
    #region frontend
    static int listaFunciones()
    {
        string Msj_inicio = "Bienvenido, que funcion desea usar?\n";
        string Funciones = ("1. Cargar boxeador N°1\n"
        + "2. Cargar boxeador N°2\n"
        + "3. ¡Pelear!\n"
        + "4. Salir del programa\n");
        Console.WriteLine(Msj_inicio + Funciones);
        return int.Parse(Console.ReadLine());
    }
    static int IngresarEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.Parse(Console.ReadLine());
    }
    static double IngresarDouble(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.Parse(Console.ReadLine());
    }
    static int IngresarEnteroVerif(string mensaje)
    {
        int retorno = 0;
        Console.WriteLine(mensaje);
        int retorn = int.Parse(Console.ReadLine());
        while (!(retorn <= 4 && retorn > 1))
        {
            Console.WriteLine("Error");
            Console.WriteLine(mensaje);
            retorn = int.Parse(Console.ReadLine());
        }
        switch (retorn)
        {
            case 1:
            retorno = 15000;
                break;
            case 2:
            retorno = 30000;
                break;
            case 3:
            retorno = 10000;
                break;
            case 4:
            retorno = 40000;
                break;
        }
        return retorno;
    }
    static double IngresarDoubleVerif(string mensaje, double verif1)
    {
        Console.WriteLine(mensaje);
        double retorn = double.Parse(Console.ReadLine());
        while (retorn < verif1)
        {
            Console.WriteLine("Error");
            Console.WriteLine(mensaje);
            retorn = double.Parse(Console.ReadLine());
        }
        if((retorn - verif1) != 0)Console.WriteLine("El vuelto es de " + (retorn - verif1));
        return retorn;
    }
    static string IngresarString(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Console.ReadLine();
    }
    static DateTime IngresarDateTime(string mensaje)
    {
        Console.WriteLine(mensaje);
        return DateTime.Parse(Console.ReadLine());
    }
    static void limpiarConsola()
    {
        Console.WriteLine("Presione una tecla para contiunar");
        Console.ReadLine();
        Console.Clear();
    }   
    #endregion
    #region backend
    static void NuevaInscripcion()
    {
        int banco;
        Clientes.Add(tiquetera.DevolverUltimoId(), (new Cliente(IngresarString(""), IngresarString(""),
        IngresarString(""), banco = IngresarEntero(""), IngresarDoubleVerif("", banco))));
    }
    static void ObtenerEstadisticas()
    {
        
    }
    #endregion
}
