class Program
{
    //Estructura de la palabra
    struct Palabra
    {
        public string palabra; //Almacena la palabra ingresada
        public int longitudtxt;//Almacena la longitud de la palabra
    }

    static void Main()
    {
        //Entrada de datos
        Console.WriteLine("Ingrese la primera palabra:");
        string textoPalabra1 = Console.ReadLine();
        //Crea una instancia en la estructura Palabra llamada palabra1 y se le asigna 
        //el valor a "palabra" y a "longitudtxt"
        Palabra palabra1 = new Palabra { palabra = textoPalabra1, longitudtxt = textoPalabra1.Length };


        Console.WriteLine("Ingrese la segunda palabra:");
        string textoPalabra2 = Console.ReadLine();
        //Crea una instancia en la estructura Palabra llamada palabra2 y se le asigna 
        //el valor a "palabra" y a "longitudtxt"
        Palabra palabra2 = new Palabra { palabra = textoPalabra2, longitudtxt = textoPalabra2.Length };

        // Se declara una variable "palabraMasLarga" de tipo "Palabra" y se le asigna el
        // resultado de llamar al método "PalabraMasLarga" pasando las estructuras "palabra1"
        // y "palabra2" como argumentos.
        Palabra palabraMasLarga = PalabraMasLarga(palabra1, palabra2);

        //Comprobar la palabra más larga
        if (palabraMasLarga.longitudtxt > 0)
        Console.WriteLine("La palabra más larga es: " + palabraMasLarga.palabra);
        
        else
        Console.WriteLine("Ambas palabras tienen la misma longitud");
            
    }
    static Palabra PalabraMasLarga(Palabra palabra1, Palabra palabra2)
    {
        //Comprobacion de cual de las dos palabras es la más larga
        if (palabra1.longitudtxt > palabra2.longitudtxt) return palabra1;
        
        else if (palabra2.longitudtxt > palabra1.longitudtxt) return palabra2;
        
        else return new Palabra();  // Si las longitudes son iguales, devuelve una palabra vacía con longitud 0

    }
}