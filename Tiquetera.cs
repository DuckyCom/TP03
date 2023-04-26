class Tiquetera
{
    #region atributos
    public static int UltimoId = 0;
    #endregion
    #region metodos
    public static int DevolverUltimoId()
    {
        UltimoId++;
        return UltimoId;
    }
    #endregion 

}