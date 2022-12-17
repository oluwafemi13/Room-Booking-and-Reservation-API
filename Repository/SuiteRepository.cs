using AutoMapper;
using Hotel_API.Data;
using Hotel_API.DTO;
using Hotel_API.Entities;
using Hotel_API.Interface;

namespace Hotel_API.Repository
{
    public class SuiteRepository : ISuiteRepository
    {
        private readonly IMapper _Mapper;
        //private readonly ILogger<SuiteRepository> _logger;
        private readonly DataBaseContext _dbContext;
        public SuiteRepository(IMapper mapper, DataBaseContext dbContext)
        {
            _Mapper = mapper;
            _dbContext = dbContext;
           
        }
        
        public async Task<Suite> CreateSuite(SuiteDTO suite)
        {
           /* var checkSuit = _dbContext.Suites.Where(x => x.Id == suite.Id && x.SuiteName == suite.SuiteName);
            if (checkSuit.Any())
            {

            }*/
            var AddSuite = _Mapper.Map<Suite>(suite);
            var added = await _dbContext.Suites.AddAsync(AddSuite);
            await _dbContext.SaveChangesAsync();
            return AddSuite;
            
               
        }

        public async Task<bool> DeleteSuite(int id)
        {
            var delete = await _dbContext.Suites.FindAsync(id);
            if(delete == null)
                return false;
            _dbContext.Remove(delete);
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<SuiteDTO> GetSuiteById(int id)
        {

            var suite = await _dbContext.Suites.FindAsync(id);
            if(suite == null)
            {
                return null;
            }
           
            var mapSuite = _Mapper.Map<Suite,SuiteDTO>(suite);
            return mapSuite;
            
            
        }

        public Task<SuiteDTO> GetSuiteByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<SuiteDTO?> GetSuiteByNumberOfBedRooms(string number)
        {
            var numberOfBedrooms = _dbContext.Suites.FirstOrDefault(x =>x.Equals(number));
            if(numberOfBedrooms  is null)
            {
                return null;
            }
            var found = _Mapper.Map<Suite, SuiteDTO>((Suite)numberOfBedrooms);
            return found;
        }

        public async Task<IEnumerable<SuiteDTO>> GetSuiteByPrice(int price)
        {
            var searchByPrice = _dbContext.Suites.Find(price);
            if (searchByPrice is null)
                return null;
            var found = _Mapper.Map<Suite, SuiteDTO>(searchByPrice);
            return (IEnumerable<SuiteDTO>)found;

        }

        public async Task<IEnumerable<SuiteDTO>> UpdateSuite(SuiteDTO suite)
        {
            var update = _dbContext.Suites.FirstOrDefault(x => x.Id == suite.Id);
            if (update is null)
                return null;
            var found = _Mapper.Map<Suite, SuiteDTO>(update);
             _dbContext.Suites.Update(update);
            _dbContext.SaveChanges();
            return (IEnumerable<SuiteDTO>)found;

        }
    }
}
