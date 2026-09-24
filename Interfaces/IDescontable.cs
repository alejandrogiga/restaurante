public interface IDescontable
{
    public decimal PorcentajeDescuento { get; set; }

    public decimal CalcularDescuento();
}
