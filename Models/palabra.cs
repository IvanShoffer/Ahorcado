using Newtonsoft.Json;
public static class palabra
{
    [JsonProperty]
    private static  List<string> palabraJugable = new List<string> {"AHORCADO", "PROGRAMACION", "TECNOLOGIA", "PROFESORA", "ARTE"};
        [JsonProperty]
    public static List<char> intentos{get; private set;} 
        [JsonProperty]
    public static bool gano{get; private set;}
        [JsonProperty]
    public static bool finalizo{get; private set;}
        [JsonProperty]
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
    public static string encontrarPalabraOculta ()
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
                resultado += " _";
            }          
    }
   
     return resultado;
    }

    public static void inicializarLetra(char letra)
    {
       
        letra = char.ToUpper(letra);
        if(intentos.Contains(letra)==false)
        {
          intentos.Add(letra);
          
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
    public static bool VerificarGanador(string palabraIngresada)
{
    palabraIngresada = palabraIngresada.ToUpper();

    if (palabraIngresada == palabraSecreta)
    {
        gano = true;
        finalizo = true;
        
    }
    else
    {
        gano = false;
    }


    return gano;
}
  
    }
    
