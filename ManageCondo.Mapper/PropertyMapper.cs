using System;
using System.Collections.Generic;
using System.Text;

namespace ManageCondo.Mapper
{
    public static class PropertyMapper
    {
        public static UsersDTO ToUsersDTO(this Users user)
        {
            UsersDTO usersDTO = new UsersDTO();
            usersDTO.Id = user.Id;
            usersDTO.Name = user.Name;
            usersDTO.Email = user.Email;
            usersDTO.Description = user.Description;

            //usersDTO.Password = user.Password;
            usersDTO.IsAdmin = user.IsAdmin;
            //usersDTO.IsGmailUser = user.IsGmailUser;
            return usersDTO;
        }

        public static List<UsersDTO> ToUsersDTOList(this IEnumerable<Users> users)
        {
            List<UsersDTO> usersDTO = new List<UsersDTO>();
            foreach (Users user in users)
            {
                usersDTO.Add(user.ToUsersDTO());
            }
            return usersDTO;
        }

        public static Users ToUser(this UsersDTO userDTO)
        {
            Users user = new Users();
            user.Id = userDTO.Id;
            user.Name = userDTO.Name;

            //user.FirstName = userDTO.FirstName;
            //user.LastName = userDTO.LastName;
            user.Email = userDTO.Email;
            //user.Password = userDTO.Password;
            //user.IsAdmin = userDTO.IsAdmin;
            //user.IsGmailUser = userDTO.IsGmailUser;
            return user;
        }
    }
}
