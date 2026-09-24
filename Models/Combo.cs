using Models;

public class Combo : Producto {
  
    public PlatoPrincipal PlatoPrincipal {get;set;}
public Bebida Bebida {get;set;}

public Postre Postre {get;set;}

public Producto? extra {get;set;}

public decimal descuento {get; set;} = 0.2m;

public decimal Precio
    {
        get
        {
            return CalcularPrecio();
        }
    }




  public Combo(string name, PlatoPrincipal platoPrincipal, Bebida bebida, Postre postre) : base(name, 0, [""])
    {
        PlatoPrincipal = platoPrincipal;
        Bebida = bebida;
        Postre = postre;
    }
    public override decimal CalcularPrecio()
    {
       decimal precioTotal = 0.0m;
       precioTotal += PlatoPrincipal.Precio + Bebida.Precio + Postre.Precio;
       return precioTotal;
    }

    public decimal PrecioConDescuento()
    {
        return Precio - (Precio*(1-descuento));
    }


    public decimal CalcularDescuento()
    {
        return Precio * 20 /100;
    }
}