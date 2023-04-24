namespace TP02BOX_CW_FE;
class Program
{
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
    static int IngresarEnteroVerif(string mensaje, int verif1, int verif2)
    {
            Console.WriteLine(mensaje);
            int retorn = int.Parse(Console.ReadLine());
            while (!(retorn >= verif1 && retorn <= verif2))
            {
                Console.WriteLine("Error");
                Console.WriteLine(mensaje);
                retorn = int.Parse(Console.ReadLine());
            }
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
    static void ObtenerBoxeador(Cliente nuevoCliente, int NumBox)
    {
        // Boxeador.nombre = IngresarEntero("Ingrese el nombre del boxeador");


        Boxeador.Nombre = IngresarString("Ingrese el nombre del pelador N°" + NumBox);
        Boxeador.Pais = IngresarString("Ingrese el pais del pelador N°" + NumBox);
        Boxeador.PotenciaGolpes = IngresarEnteroVerif("Ingrese la potencia de los golpes del peleador, recuerde que tiene que ser entre 1 y 100", 1, 100);
        Boxeador.Peso = IngresarEntero("Ingrese el peso (en KG) del peleador N°" + NumBox);
        Boxeador.VelocidadPiernas = IngresarEnteroVerif("Ingrese la velocidad de las piernas del peleador, recuerde que tiene que ser entre 1 y 100", 1, 100);
    }
    #endregion
}
