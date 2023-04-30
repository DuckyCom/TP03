class Cliente
{
    #region atributos
    public string DNI {get; private set;}
    public string Apellido {get; private set;}
    public string Nombre {get; private set;}
    public DateTime FechaInscripcion {get; private set;}
    public int TipoEntrada {get; private set;}
    public double TotalAbonado {get; private set;}
    #endregion
    #region constru
    public Cliente(string dni, string apellido, string nombre, int tipoentrada, double totalabonado)
    {
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
        FechaInscripcion = DateTime.Now;
        TipoEntrada = tipoentrada;
        TotalAbonado = totalabonado;
    }
    #endregion
    #region metodos
    public bool CambiarEntrada(int NuevaEntrada, double NuevoTotal)
    {   
        bool retorn = false;
        if (TipoEntrada < NuevaEntrada || NuevaEntrada == 3)
        {
            Console.WriteLine("No se puede pasar de un pase mas caro a uno mas barato (No se puede cambiar al tipo 3 debido a que es el pago mas barato)");
        }
        else if (NuevaEntrada > 4 && NuevaEntrada <= 0)
        {
            Console.WriteLine("Tipo de entrada incorrecta");
        }
        else if (NuevoTotal > TransformarPrecio(NuevaEntrada))
        {
            if((NuevoTotal - TransformarPrecio(NuevaEntrada)) != 0)Console.WriteLine("El vuelto es de " + (NuevoTotal - TransformarPrecio(NuevaEntrada)));
            TotalAbonado = NuevoTotal;
            TipoEntrada = NuevaEntrada;
            retorn = true;
            FechaInscripcion = DateTime.Now;
        }
        return retorn;
    }
    #endregion 
    public static double TransformarPrecio(int entrada)
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

}