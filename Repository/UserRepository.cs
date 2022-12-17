using AutoMapper;
using Hotel_API.Data;
using Hotel_API.DTO;
using Hotel_API.Entities;
using Hotel_API.Repository.Interface;

namespace Hotel_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _Db;
        private readonly IMapper _mapper;

        public UserRepository(DataBaseContext Db,
            IMapper mapper)
        {
            _Db = Db;
            _mapper = mapper;
        }
        public async Task<UserDTO> CreateUser(UserDTO userDTO)
        {
            var check = _Db.Users.FirstOrDefault(u =>u.Email == userDTO.Email);
            if(check != null)
            {
                var mapping = _mapper.Map<UserDTO>(check);
                return mapping;
            }
            var mapUser = _mapper.Map<User>(userDTO);
            var newMap = _mapper.Map<UserDTO>(mapUser);
           await  _Db.Users.AddAsync(mapUser);
            _Db.SaveChanges();
            return newMap;
           
        }

        public async Task<bool> DeleteUser(int id)
        {
            var user = await _Db.Users.FindAsync(id);
            if (user == null)
                return false;
            _Db.Remove(user);
            _Db.SaveChanges();
            return true;

            
        }

        public async Task<UserDTO> GetUserByEmail(string email)
        {
            var checkEmail = _Db.Users.FirstOrDefault(x=> x.Equals(email));
            if (checkEmail is null)
            {
                return null;
            }
            var check = _mapper.Map<UserDTO>(checkEmail);
            return check;
        }

        public Task<UserDTO> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateUser(UserDTO userDTO)
        {
            if(userDTO == null)
                return null;

            var update = await _Db.Users.FindAsync(userDTO.Id);
            if (update is null)
                return null;
            var mapped = _mapper.Map<User>(userDTO);
            var newMap = _mapper.Map<UserDTO>(mapped);
            var found = _Db.Update(mapped);
            await _Db.SaveChangesAsync();

            return mapped;

        }
    }
}
