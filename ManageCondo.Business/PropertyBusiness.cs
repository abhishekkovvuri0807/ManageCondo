using ManageCondo.DomainLayer;
using ManageCondo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCondo.Business
{
    public class PropertyBusiness
    {
        private readonly IPropertyRepository _propertyRepository;
        public PropertyBusiness(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public async Task<IEnumerable<Property>> GetAllProperties()
        {
            IEnumerable<Property> properties = await _propertyRepository.GetAllProperties();
            return properties;
        }

        public void AddProperty(Property property)
        {
             _propertyRepository.AddProperty(property);
        }

        public void UpdateProperty(Property property)
        {
            _propertyRepository.UpdateProperty(property);
        }

        public Property GetPropertyDetails(int propertyID)
        {
            return _propertyRepository.GetPropertyDetails(propertyID);
        }

        public void DeleteProperty(Property property)
        {
            _propertyRepository.DeleteProperty(property);
        }

        //public async Task<Result<bool>> AddUser(UsersDTO userDTO)
        //{
        //    Users user = userDTO.ToUser();
        //    user.CreatedDate = DateTime.Now;
        //    user.UpdatedDate = DateTime.Now;
        //    bool result = await _userRepository.AddUser(user);
        //    if (result)
        //    {
        //        return Result<bool>.Success(result, BusinessConstants.REGISTRATION_SUCCESS);
        //    }
        //    return Result<bool>.Fail(BusinessConstants.REGISTRATION_FAIL);
        //}
    }
}
