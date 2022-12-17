using Hotel_API.DTO;
using Hotel_API.Entities;

namespace Hotel_API.Interface
{
    public interface ISuiteRepository
    {
        Task<SuiteDTO> GetSuiteById(int id);
        Task<SuiteDTO> GetSuiteByName(string name);
        Task<IEnumerable<SuiteDTO>> GetSuiteByPrice(int price);
        Task<SuiteDTO> GetSuiteByNumberOfBedRooms(string number);
        Task<Suite> CreateSuite(SuiteDTO suite);
        Task<IEnumerable<SuiteDTO>> UpdateSuite(SuiteDTO suite);
        Task<bool> DeleteSuite(int id);



    }
}
