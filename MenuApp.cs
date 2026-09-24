using Models;

class MenuApp
{
    private Pedido pedido;
    private const int OpcionSalir = 7;

    public MenuApp()
    {
        pedido = new Pedido();
    }

    public void MostrarMenu()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n--- Menú del Restaurante ---");
            Console.WriteLine("1. Añadir Plato Principal");
            Console.WriteLine("2. Añadir Bebida");
            Console.WriteLine("3. Añadir Postre");
            Console.WriteLine("4. Mostrar Pedido");
            Console.WriteLine("5. Calcular Total");
            Console.WriteLine("6. Comprobar productos con descuento");
            Console.WriteLine("7. Salir");
            Console.WriteLine("Selecciona una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion) ||  opcion < 1 ||  opcion > OpcionSalir)
            {
                Console.WriteLine("Error: selecciona una opción válida (1-7).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    AnadirPlato();
                    break;

                case 2:
                    AnadirBebida();
                    break;

                case 3:
                    AnadirPostre();
                    break;

                case 4:
                    pedido.MostrarPedido();
                    break;

                case 5:
                    decimal total = pedido.CalcularTotal();
                    Console.WriteLine($"\nTotal a pagar: {total:C}");
                    break;
                case 6:
                   ComprobarProductosConDescuento();
                    break;
                case OpcionSalir:
                    Console.WriteLine("Adiós");
                    break;
            }

        } while (opcion != OpcionSalir);
    }

    private List<string> PedirIngredientes()
    {
        Console.WriteLine("Ingredientes separados por comas:");
        string textoIngredientes = Console.ReadLine();

        string[] ingredientesArray = textoIngredientes.Split(',');

        List<string> ingredientes = new List<string>();

        foreach (string ingrediente in ingredientesArray)
        {
            ingredientes.Add(ingrediente.Trim());
        }

        return ingredientes;
    }

    private void AnadirPlato()
    {
        Console.WriteLine("Nombre del plato:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Precio del plato:");

        if (!decimal.TryParse(Console.ReadLine(), out decimal precio) ||
            precio <= 0)
        {
            Console.WriteLine("Error: el precio debe ser un número positivo.");
            return;
        }

        List<string> ingredientes = PedirIngredientes();

        PlatoPrincipal plato =
            new PlatoPrincipal(nombre, precio, ingredientes);

        pedido.AnadirProducto(plato);

        Console.WriteLine("Plato añadido al pedido.");
    }

    private void AnadirBebida()
    {
        Console.WriteLine("Nombre de la bebida:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Precio de la bebida:");

        if (!decimal.TryParse(Console.ReadLine(), out decimal precio) ||
            precio <= 0)
        {
            Console.WriteLine("Error: el precio debe ser un número positivo.");
            return;
        }

         List<string> ingredientes = PedirIngredientes();

        Console.WriteLine("¿Es alcohólica? (sí/no):");
        string respuesta = Console.ReadLine().Trim().ToLower();

        bool esAlcoholica = respuesta == "sí" || respuesta == "si";

        Bebida bebida =
            new Bebida(nombre, precio, ingredientes, esAlcoholica);

        pedido.AnadirProducto(bebida);

        Console.WriteLine("Bebida añadida al pedido.");
    }

    private void AnadirPostre()
    {
        Console.WriteLine("Nombre del postre:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Precio del postre:");

        if (!decimal.TryParse(Console.ReadLine(), out decimal precio) ||
            precio <= 0)
        {
            Console.WriteLine("Error: el precio debe ser un número positivo.");
            return;
        }

        List<string> ingredientes = PedirIngredientes();

        Console.WriteLine("Calorías:");

        if (!int.TryParse(Console.ReadLine(), out int calorias) ||
            calorias < 0)
        {
            Console.WriteLine("Error: las calorías deben ser un número válido.");
            return;
        }

         Console.WriteLine("¿Es sugarfree? (sí/no):");
        string respuesta = Console.ReadLine().Trim().ToLower();

        bool esSugarFree = respuesta == "sí" || respuesta == "si";

        Postre postre =
            new Postre(nombre, precio, ingredientes, calorias, esSugarFree);

        pedido.AnadirProducto(postre);

        Console.WriteLine("Postre añadido al pedido.");
    }

    private void ComprobarProductosConDescuento() {
         foreach (Producto producto in pedido.productos)
    {
        if (producto is IDescontable descontable)
        {
            descontable.PorcentajeDescuento = 10;

            Console.WriteLine(
                $"{producto.Nombre} admite descuento"
            );
        }
    }
    }
    


}