namespace Models;

public class Pedido
{
    public List<Producto> productos;

    public Pedido()
    {
        productos = new List<Producto>();
    }

    public void AnadirProducto(Producto producto)
    {
        productos.Add(producto);
        Console.WriteLine($"Producto añadido: {producto.Nombre}");
    }

    public void MostrarPedido()
    {
        Console.WriteLine("\n--- Pedido ---");

        foreach (Producto producto in productos)
        {
            producto.MostrarDetalles();
        }
    }

    public void MostrarBebidas()
    {
        Console.WriteLine("\n--- Bebidas del pedido ---");

        foreach (Producto producto in productos)
        {
            if (producto is Bebida bebida)
            {
                bebida.MostrarDetalles();
                Console.WriteLine($"Alcohólica: {bebida.EsAlcoholica}");
            }
        }
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;

        foreach (Producto producto in productos)
        {
            total += producto.Precio;
        }

        return total;
    }
}