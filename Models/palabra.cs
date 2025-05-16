public static class palabra
{
    private static  List<string> palabraJugable = new List<string> {"AHORCADO", "PROGRAMACION", "TECNOLOGIA", "PROFESORA", "ARTE"};
    public static List<char> intentos{get; private set;} 
    public static bool gano{get; private set;}
    public static bool finalizo{get; private set;}

    public static void inicializarLetra(char letra)
    {
       
        letra = char.ToUpper(letra);
        if(intentos.Contains(letra)==false)
        {
          intentos.Add(letra);
        }
        
    }
    

}

