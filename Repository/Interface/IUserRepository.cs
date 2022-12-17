using Hotel_API.Data;
using Hotel_API.DTO;
using Hotel_API.Entities;

namespace Hotel_API.Repository.Interface
{
    public interface IUserRepository
    {
       
        Task<UserDTO> GetUserById(int id);  
        Task<UserDTO> GetUserByEmail(string email);
        Task<UserDTO> CreateUser(UserDTO userDTO);
        Task<User> UpdateUser(UserDTO userDTO);
        Task<bool> DeleteUser(int id);
    }
}
