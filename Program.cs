
using Models;

PlatoPrincipal platoPrincipal1 = new PlatoPrincipal("Pizza", 12, ["Tomate", "Queso"]);
platoPrincipal1.MostrarDetalles();

Bebida bebida1 = new Bebida("Cocacola", 8.5m, ["Cafeina", "Limón"], false);
bebida1.MostrarDetalles();

bebida1.PorcentajeDescuento = 10;

decimal descuento =
    bebida1.CalcularDescuento();

Console.WriteLine(descuento);


Bebida cerveza =
    new Bebida(
        "Cerveza",
        4m,
        [""],
        true
    );

cerveza.Alergenos.Add("Gluten");
cerveza.Alergenos.Add("Sulfitos");
Console.WriteLine(
      cerveza.ContieneAlergeno("Gluten")
);

Console.WriteLine(
    cerveza.ContieneAlergeno("Lactosa")
);

Postre postre1 = new Postre("Tarta de queso", 12.45m, ["Leche", "Queso", "Huevos"], 300, false);
postre1.MostrarDetalles();

//Producto producto1 = new Producto("Entrante",15m, ["Lechuga, carne"] );

List<Producto> combo = new ();// = [platoPrincipal1, bebida1, postre1];
combo.Add(platoPrincipal1);
combo.Add(bebida1);
combo.Add(postre1);


Console.WriteLine(combo);

foreach (Producto producto in combo)
{
    Console.WriteLine(producto);
    Console.WriteLine(producto.Nombre + "-" + producto.Precio);
    producto.MostrarDetalles();
}


Combo combo1 = new Combo("menú del dia", platoPrincipal1, bebida1, postre1);
Console.WriteLine(combo1.Precio);

Producto p1 = (Producto)combo1;

Console.WriteLine(p1.Precio);

Console.WriteLine(combo1.PrecioConDescuento());
decimal cantidadDescontada = combo1.CalcularDescuento();
Console.WriteLine("End");


var menuApp = new MenuApp();
menuApp.MostrarMenu();
