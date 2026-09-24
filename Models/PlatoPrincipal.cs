using Microsoft.VisualBasic;

namespace Models;

public class PlatoPrincipal : Producto
{
    public PlatoPrincipal(string name, decimal price, List<string> ingredientes) : base(name, price, ingredientes)
    {
    }

        public override decimal CalcularPrecio()
    {
        throw new NotImplementedException();
    }
}