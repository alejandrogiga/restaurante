using Microsoft.VisualBasic;

namespace Models;

public class PlatoPrincipal : Producto, IDescontable
{
    public PlatoPrincipal(string name, decimal price, List<string> ingredientes) : base(name, price, ingredientes)
    {
    }

    public decimal PorcentajeDescuento { get; set; }

    public decimal CalcularDescuento()
    {
         return Precio *
           PorcentajeDescuento / 100;
    }

    public override decimal CalcularPrecio()
    {
        throw new NotImplementedException();
    }
}