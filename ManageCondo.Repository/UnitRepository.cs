using ManageCondo.DomainLayer;
using ManageCondo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageCondo.Repository
{
    public class UnitRepository : IUnitRepository
    {
        private readonly ManageCondoContext _dbContext;

        public UnitRepository(ManageCondoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Unit> GetAllUnits()
        {
            return _dbContext.Unit.ToList();
        }
    }
}
