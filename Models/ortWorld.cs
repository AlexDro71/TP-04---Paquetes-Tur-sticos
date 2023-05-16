class ortWorld
{
    public static List<string> ListaDestinos = new List<string> { "Cancun", "Rio de Janeiro", "Miami", "Roma", "Ohio", "Machu Pichu", "Hawai", "Uruguay", "Bolivia", "Ottawa" };
    public static List<string> ListaHoteles = new List<string> { "hotel1.jpg", "hotel2.jpg", "hotel3.jpg", "hotel4.jpg", "hotel5.jpg", "hotel6.jpg", "hotel7.jpg", "hotel8.jpg", "hotel9.jpg", "hotel10.jpg" };
    public static List<string> ListaAereos = new List<string> { "Aereo1.png", "Aereo2.png", "Aereo3.png", "Aereo4.png", "Aereo5.png", "Aereo6.png", "Aereo7.png", "Aereo8.png", "Aereo9.png", "Aereo10.png" };
    public static List<string> ListaExcursiones = new List<string> {"excursion1.jpg", "excursion2.jpg", "excursion3.jpg", "excursion4.jpg", "excursion5.jpg", "excursion6.jpg", "excursion7.jpg", "excursion8.jpg", "excursion9.jpg", "excursion10.jpg" };
    public static Dictionary<string, Paquete>Paquetes { get; private set; } = new Dictionary<string, Paquete>();
    


    public static bool ingresarPaquete(string destinoSeleccionado, Paquete paq)
    {
        if (Paquetes.ContainsKey(destinoSeleccionado))
        {
            return false;
        }
        else
        {
            Paquetes.Add(destinoSeleccionado, paq);
            return true;
        }


    }

}