using Microsoft.VisualBasic;

namespace Models;

public class Bebida : Producto
{
    public bool IsAlcoholica {get;set;}
    public Bebida(string name, decimal price, List<string> ingredientes, bool isAlcoholica) : base(name, price, ingredientes)
    {
        IsAlcoholica = isAlcoholica;
    }

    public override decimal CalcularPrecio()
    {
        throw new NotImplementedException();
    }
}