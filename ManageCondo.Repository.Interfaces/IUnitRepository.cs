using ManageCondo.DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManageCondo.Repository.Interfaces
{
    public interface IUnitRepository
    {
        IEnumerable<Unit> GetAllUnits();
    }
}
