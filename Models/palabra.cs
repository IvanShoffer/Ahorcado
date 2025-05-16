public static class palabra
{
    private static  List<string> palabraJugable = new List<string> {"AHORCADO", "PROGRAMACION", "TECNOLOGIA", "PROFESORA", "ARTE"};
    public static List<char> intentos{get; private set;} 
    public static bool gano{get; private set;}
    public static bool finalizo{get; private set;}
    public static void nuevaPartida()
    {
        Random random = new Random();
       int numeroAleatorio = random.Next(0, palabraJugable.Count);
       string palabraSecreta = palabraJugable[numeroAleatorio];



    }
    public static void encontrarPalabraOculta ( string palabraSecreta)
    {
        string resultado = "";
    for (int i = 0; i < palabraSecreta.Count(); i++)
    {
       
    }
    }

    public static void inicializarLetra(char letra)
    {
       
        letra = char.ToUpper(letra);
        if(intentos.Contains(letra)==false)
        {
          intentos.Add(letra);
        }
        
    }
    

}

