class Tiquetera
{
    #region atributos
    public static int UltimoId = 0;
    #endregion
    #region metodos
    public int DevolverUltimoId()
    {
        UltimoId++;
        return UltimoId;
    }
    #endregion 

}