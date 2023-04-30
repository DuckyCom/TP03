namespace TP02BOX_CW_FE;
using System.Collections.Generic;
class Program
{
    public static Dictionary<int, Cliente> Clientes = new Dictionary<int, Cliente>();
    public static Tiquetera Tiquetera;
    static void Main(string[] args)
    {
        bool Cambio;
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
            NuevaInscripcion();
            limpiarConsola();
                break;
            case 2:
            ObtenerEstadisticas();
            limpiarConsola();
                break;
            case 3:
            BuscarCliente(IngresarEntero("Ingrese el ID"));
            limpiarConsola(); 
                break;
            case 4:
            Cambio = CambioEntrada(IngresarEntero("Ingrese el ID"));
            if (!Cambio) Console.WriteLine("No se pudo completar el cambio, seguramente sea por un error que aparezca arriba");
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
        string Funciones = ("1. Nueva Inscripción\n"
        + "2. Estadisticas del evento\n"
        + "3. Buscar cliente\n"
        + "4. Cambiar entrada de un cliente\n"
        + "5. Salir");
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
        Console.WriteLine(mensaje);
        int retorn = int.Parse(Console.ReadLine());
        while (!(retorn <= 4 && retorn >= 1))
        {
            Console.WriteLine("Error");
            Console.WriteLine(mensaje);
            retorn = int.Parse(Console.ReadLine());
        }
        return retorn;
    }
    static double IngresarDoubleVerif(string mensaje, int verif1)
    {
        Console.WriteLine(mensaje);
        double retorn = double.Parse(Console.ReadLine());
        while (retorn < TransformarPrecio(verif1))
        {
            Console.WriteLine("Error");
            Console.WriteLine(mensaje);
            retorn = double.Parse(Console.ReadLine());
        }
        if((retorn - TransformarPrecio(verif1)) != 0)Console.WriteLine("El vuelto es de " + (retorn - TransformarPrecio(verif1)));
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
        Cliente cli = new Cliente(IngresarString("Ingrese su DNI"), IngresarString("Ingrese su apellido"),
        IngresarString("Ingrese su nombre"), banco = IngresarEnteroVerif("Ingrese el tipo de entrada"),
        IngresarDoubleVerif("Ingrese la cantidad a pagar (DEBE SER MAYOR A LA CANTIDAD PEDIDA POR TIPO DE ENTRADA)", banco));
        int ti = Tiquetera.DevolverUltimoId();
        Clientes.Add(ti, cli);
    }
    static void ObtenerEstadisticas()
    {
        double porcentajeDia1 = 0, porcentajeDia2 = 0, porcentajeDia3 = 0, porcentajeFullPass = 0;
        int CantPersonasInscriptas = 0;
        double RecaudacionTotal = 0;
        double dia1Recaudacion = 0, dia2Recaudacion = 0, dia3Recaudacion = 0, fullPassRecaudacion = 0;
        int dia1 = 0, dia2 = 0, dia3 = 0, fullPass = 0;
        CantPersonasInscriptas = Clientes.Count();
        foreach (int x in Clientes.Keys)
        {
            RecaudacionTotal += Clientes[x].TotalAbonado;
            switch (Clientes[x].TipoEntrada)
            {
                case 1:
                dia1Recaudacion += Clientes[x].TotalAbonado;
                dia1++;
                    break;
                case 2:
                dia2Recaudacion += Clientes[x].TotalAbonado;
                dia2++;
                    break;
                case 3:
                dia3Recaudacion += Clientes[x].TotalAbonado;
                dia3++;
                    break;
                case 4:
                fullPassRecaudacion += Clientes[x].TotalAbonado;
                fullPass++;
                    break;
            }
        }
        porcentajeDia1 = CalcularPorcentaje(dia1, Clientes.Count);
        porcentajeDia2 = CalcularPorcentaje(dia2, Clientes.Count);
        porcentajeDia3 = CalcularPorcentaje(dia3, Clientes.Count);
        porcentajeFullPass = CalcularPorcentaje(fullPass, Clientes.Count);
        Console.WriteLine("La cantidad de clientes inscriptos es de: " + Clientes.Count() + "\n" +
        "El porcentaje de tipo 1 es de: " + porcentajeDia1 + "%\n" +
        "Su recaudacion es de: " + dia1Recaudacion + "\n" +
        "El porcentaje de tipo 2 es de: " + porcentajeDia2 + "%\n" +
        "Su recaudacion es de: " + dia2Recaudacion + "\n" +
        "El porcentaje de tipo 3 es de: " + porcentajeDia3 + "%\n" +
        "Su recaudacion es de: " + dia3Recaudacion + "\n" +
        "El porcentaje de tipo Full Pass es de: " + porcentajeFullPass + "%\n" +
        "Su recaudacion es de: " + fullPassRecaudacion + "\n\n" + 
        "La recaudacion total es de " + RecaudacionTotal);
    }
    static void BuscarCliente(int x)
    {
        string TipoEntradaEncontrada = "";
        switch (Clientes[x].TipoEntrada)
                {
                    case 1:
                    TipoEntradaEncontrada = "Dia 1";
                        break;
                    case 2:
                    TipoEntradaEncontrada = "Dia 2";
                        break;
                    case 3:
                    TipoEntradaEncontrada = "Dia 3";
                        break;
                    case 4:
                    TipoEntradaEncontrada = "Full pass";
                        break;
                }
                Console.WriteLine("Dni N°" + Clientes[x].DNI + "\nNombre: " + Clientes[x].Nombre + "\nApellido: " + Clientes[x].Apellido +
                "\nFecha de inscripcion: " + Clientes[x].FechaInscripcion + "\nTipo de entrada: " + TipoEntradaEncontrada +
                "\nTotal abonado: " + Clientes[x].TotalAbonado);
    }
    static bool CambioEntrada(int x)
    {
        bool Posible = Clientes[x].CambiarEntrada(IngresarEntero("Ingrese el nuevo tipo de entrada: \n1. Dia 1 con valor de 15.000 \n2. Dia 2 con valor de 30000 " +
        "\n3. Dia 3 con valor de 10000 \n4. Todos los dias con valor de 40000"), IngresarDouble("Ingrese el nuevo abonado"));
        return Posible;
    }
    static double TransformarPrecio(int entrada)
    {
        double retorn = 0;
        switch (entrada)
        {
            case 1:
            retorn = 15000;
                break;
            case 2:
            retorn = 30000;
                break;
            case 3:
            retorn = 10000;
                break;
            case 4:
            retorn = 40000;
                break;
        }
        return retorn;
    }
    static double CalcularPorcentaje(double valor1, double valor2)
    {
        return valor1*100 / valor2;
    }
    #endregion
}
