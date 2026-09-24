using Microsoft.VisualBasic;

namespace Models;

public abstract class Producto
{
    public string Nombre {get;set;}
    public decimal Precio {get;set;}

    public List<string> Ingredientes {get;set;} = new();

   // public List<string> Alergenos {get;set;}

   // public List<string> Type {get;set;}

    public Producto (string name, decimal price, List<string> ingredientes)
    {
        this.Nombre = name;
        Precio = price;
        Ingredientes = ingredientes;
    }

    public void ShowDesc()
    {
       // Console.WriteLine("Name: " + this.Name + " - " + "Price: " + this.Price);
        Console.WriteLine($"Name: {this.Nombre} - Price: {this.Precio:F2}");
    }

    public abstract decimal CalcularPrecio();
    
}