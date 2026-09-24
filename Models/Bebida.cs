
namespace Models;

public class Bebida : Producto, IDescontable, IConAlergenos
{
    public bool EsAlcoholica {get;set;}
    public decimal PorcentajeDescuento {  get; set; }
    public List<string> Alergenos { get; set; } = new List<string>();


    public Bebida(string name, decimal price, List<string> ingredientes, bool esAlcoholica) : base(name, price, ingredientes)
    {
        EsAlcoholica = esAlcoholica;
    }

    public Bebida(string name, decimal price, List<string> ingredientes) : base(name, price, ingredientes)
    {
    }

    public override decimal CalcularPrecio()
    {
        throw new NotImplementedException();
    }

    public decimal CalcularDescuento()
    {
       return Precio *
           PorcentajeDescuento / 100;
    }

    public bool ContieneAlergeno(string alergeno)
    {
          return Alergenos.Contains(alergeno);
    }

    /*
            public override string MostrarDetalles()
        {
            string alcohol = EsAlcoholica
                ? "Con alcohol"
                : "Sin alcohol";

            return $"{Nombre} - {alcohol}";
        }
    */

}