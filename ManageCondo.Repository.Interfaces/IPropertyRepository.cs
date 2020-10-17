using ManageCondo.DomainLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCondo.Repository.Interfaces
{
    public interface IPropertyRepository
    {
        Task<IEnumerable<Property>> GetAllProperties();

        void AddProperty(Property property);

        void UpdateProperty(Property property);

        Property GetPropertyDetails(int propertyID);

        void DeleteProperty(Property property);
    }
}
