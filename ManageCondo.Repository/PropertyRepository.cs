using ManageCondo.DomainLayer;
using ManageCondo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageCondo.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly ManageCondoContext _dbContext;

        public PropertyRepository(ManageCondoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Property>> GetAllProperties()
        {
            return await _dbContext.Property.ToListAsync();
        }

        public void AddProperty(Property property)
        {
            _dbContext.Property.Add(property);
            _dbContext.SaveChanges();
        }

        public void UpdateProperty(Property property)
        {
            _dbContext.Property.Update(property);
            _dbContext.SaveChanges();
        }

        public Property GetPropertyDetails(int propertyID)
        {
            return _dbContext.Property.Where(p => p.ID == propertyID).FirstOrDefault();
        }

        public void DeleteProperty(Property property)
        {
            _dbContext.Property.Remove(property);
            _dbContext.SaveChanges();
        }
    }
}
