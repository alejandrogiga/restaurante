using Microsoft.VisualBasic;

namespace Models;

public class Postre : Producto
{
    public decimal NumCalorias {get;set;}
    public bool IsSugarFree {get;set;}
    public Postre(string name, decimal price, List<string> ingredientes, decimal numCalorias, bool isSugarFree) : base(name, price, ingredientes)
    {
        NumCalorias = numCalorias;
        IsSugarFree = isSugarFree;
    }

        public override decimal CalcularPrecio()
    {
        throw new NotImplementedException();
    }
}