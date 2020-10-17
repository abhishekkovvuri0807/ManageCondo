using ManageCondo.DomainLayer;
using ManageCondo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManageCondo.Mapper
{
    public static class PropertyMapper
    {
        public static PropertyViewModel ToPropertyViewModel(this Property property)
        {
            PropertyViewModel propertyViewModel = new PropertyViewModel();
            propertyViewModel.ID = property.ID;
            propertyViewModel.Name = property.Name;
            propertyViewModel.Address = property.Address;
            propertyViewModel.Email = property.Email;
            propertyViewModel.Description = property.Description;
            propertyViewModel.Status = property.Status;
            return propertyViewModel;
        }

        public static List<PropertyViewModel> ToPropertyViewModelList(this IEnumerable<Property> properties)
        {
            List<PropertyViewModel> usersDTO = new List<PropertyViewModel>();
            foreach (Property property in properties)
            {
                usersDTO.Add(property.ToPropertyViewModel());
            }
            return usersDTO;
        }

        public static Property ToProperty(this PropertyViewModel propertyViewModel)
        {
            Property property = new Property();
            property.ID = propertyViewModel.ID;
            property.Name = propertyViewModel.Name;
            property.Address = propertyViewModel.Address;
            property.Email = propertyViewModel.Email;
            property.Description = propertyViewModel.Description;
            property.Status = propertyViewModel.Status;
            return property;
        }
    }
}
