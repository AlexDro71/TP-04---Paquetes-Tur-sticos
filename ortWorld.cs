class ortWorld{
public List<string> ListaDestinos = new List<string> {"Cancun", "Rio de Janeiro", "Miami", "Roma", "Ohio", "Machu Pichu", "Hawaii", "Uruguay", "Bolivia", "Ottawa"}; 
public List<string> ListaHoteles = new List<string> {"hotel1.jpg", "hotel2.jpg", "hotel3.jpg", "hotel4.jpg", "hotel5.jpg", "hotel6.jpg", "hotel7.jpg", "hotel8.jpg", "hotel9.jpg", "hotel10.jpg"};
public List<string> ListaAereos = new List<string> {"Aereo1.png", "Aereo2.png", "Aereo3.png", "Aereo4.png", "Aereo5.png", "Aereo6.png", "Aereo7.png", "Aereo8.png", "Aereo9.png" ,"Aereo10.png"};
public  List<string> ListaExcursiones {get; private set;}
public Dictionary<string, Paquete> Paquetes {get; private set;}

public ortWorld(List<string> destinos, List<string> hoteles, List<string> aereos, List<string> excursiones, Dictionary<string, Paquete> paqs){
ListaAereos = aereos;
ListaDestinos = destinos;
ListaHoteles = hoteles;
ListaExcursiones = excursiones;
Paquetes = paqs;

}


}