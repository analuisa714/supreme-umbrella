public class Circulo 
{
    public double Raio { get;}

    public Circulo(double raio)
    {
        Raio = raio;
    }
    
    public double CalcularPerimetro{ get=>2*3.14*Raio;}
    public double CalcularArea{ get=>3.14*Raio*Raio;}
    
}