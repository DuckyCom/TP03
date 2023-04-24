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
        TipoEntrada = tipoentrada;
        TotalAbonado = totalabonado;
    }
    #endregion
    #region metodos
    public bool CambiarEntrada()
    {   
    }
  
    #endregion 

}