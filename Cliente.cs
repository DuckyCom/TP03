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
        if (TotalAbonado > NuevoTotal)
        {
            Console.WriteLine("No se puede pasar de un pase mas caro a uno mas caro");
        }
        else
        {
            switch (NuevaEntrada)
            {
                case 1:
                if (NuevoTotal > 15000)
                {
                    if((NuevoTotal - TotalAbonado) != 0)Console.WriteLine("El vuelto es de " + (NuevoTotal - TotalAbonado));
                    TotalAbonado = NuevoTotal;
                    TipoEntrada = NuevaEntrada;
                    retorn = true;
                    FechaInscripcion = DateTime.Now;
                }
                else Console.WriteLine("Pago insuficiente");
                    break;
                case 2:
                if (NuevoTotal > 30000)
                {
                    if((NuevoTotal - TotalAbonado) != 0)Console.WriteLine("El vuelto es de " + (NuevoTotal - TotalAbonado));
                    TotalAbonado = NuevoTotal;
                    TipoEntrada = NuevaEntrada;
                    retorn = true;
                    FechaInscripcion = DateTime.Now;
                }
                else Console.WriteLine("Pago insuficiente");
                    break;
                case 4:
                if (NuevoTotal > 40000)
                {
                    if((NuevoTotal - TotalAbonado) != 0)Console.WriteLine("El vuelto es de " + (NuevoTotal - TotalAbonado));
                    TotalAbonado = NuevoTotal;
                    TipoEntrada = NuevaEntrada;
                    retorn = true;
                    FechaInscripcion = DateTime.Now;
                }
                else Console.WriteLine("Pago insuficiente");
                    break;
                default:
                Console.WriteLine("Tipo de entrada incorrecta (No se puede cambiar al tipo 3 debido a que es el pago mas barato)");
                    break;
                }
        }
        return retorn;
    }
    #endregion 

}