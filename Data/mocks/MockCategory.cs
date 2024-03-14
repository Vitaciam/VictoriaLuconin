using VictoriaLuconin.Data.interfaces;
using VictoriaLuconin.Data.models;

namespace VictoriaLuconin.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> { 
                
                new Category{ categoryName = " Автомобили из Кореи", description = "Современный вид транспорта" },
                new Category{ categoryName = "Автомобили из Китая", description = "Машины"}
                };
            }
        }
    }
}
