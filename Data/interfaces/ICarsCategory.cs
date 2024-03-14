using VictoriaLuconin.Data.models;

namespace VictoriaLuconin.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
