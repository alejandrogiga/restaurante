public interface IConAlergenos
{
    List<string> Alergenos { get; set; }

    bool ContieneAlergeno(string alergeno);
}
