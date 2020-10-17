using ManageCondo.DomainLayer;
using ManageCondo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManageCondo.Business
{
    public class UnitBusiness
    {
        private readonly IUnitRepository _unitRepository;
        public UnitBusiness(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public IEnumerable<Unit> GetAllUnits()
        {
            IEnumerable<Unit> units = _unitRepository.GetAllUnits();
            return units;
        }
    }
}
