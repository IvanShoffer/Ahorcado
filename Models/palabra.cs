public static class palabra
{
    private static  List<string> palabraJugable = new List<string> {"AHORCADO", "PROGRAMACION", "TECNOLOGIA", "PROFESORA", "ARTE"};
    public static List<char> intentos{get; private set;} 
    public static bool gano{get; private set;}
    public static bool finalizo{get; private set;}
      public static string palabraSecreta;
 
    public static void nuevaPartida()
    {
        Random random = new Random();
       int numeroAleatorio = random.Next(0, palabraJugable.Count);
        palabraSecreta = palabraJugable[numeroAleatorio];
        intentos = new List<char>(); 
        gano = false;
        finalizo = false;



    }
    public static bool encontrarPalabraOculta ()
    {
        string resultado = "";
    for (int i = 0; i < palabraSecreta.Count(); i++)
    {

            if (intentos.Contains(palabraSecreta[i]))
            {
                resultado += palabraSecreta[i];
               
            }
            else
            {
                resultado += "_";
            }          
    }
     bool gano = ArriesgarPalabra(resultado);
     return gano;
    }

    public static void inicializarLetra(char letra)
    {
       
        letra = char.ToUpper(letra);
        if(intentos.Contains(letra)==false)
        {
          intentos.Add(letra);
          verificarGanador();
        }
        
    }
    public static bool ArriesgarPalabra(string palabraIngresada)
{
    palabraIngresada = palabraIngresada.ToUpper();

    if (palabraIngresada == palabraSecreta)
    {
        gano = true;
    }
    else
    {
        gano = false;
    }

    finalizo = true; 
    return gano;
}
    public static bool verificarGanador()

    {
        
      string palabraFinal = encontrarPalabraOculta();
      
    if (palabraFinal == palabraSecreta)
    {
        gano = true;
    }
    else
    {
        gano = false;
    }

    finalizo = true; 
    return gano;
}
    }
    
