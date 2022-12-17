using Hotel_API.Data;
using Hotel_API.Entities;
using Hotel_API.Repository.Interface;

namespace Hotel_API.Repository
{
    public class BookingDetailsRepository : IBookingDetailsRepository
    {
        private readonly DataBaseContext _Db;
        
        public BookingDetailsRepository(DataBaseContext Db)
        {
            _Db = Db;   
        }

        public async Task<BookingDetail> CreateBooking(BookingDetail bookingDetail)
        {
           if(bookingDetail == null)
                return null;
           var create = await _Db.BookingDetails.AddAsync(bookingDetail);
            _Db.SaveChanges();
            return bookingDetail;
        }

        public async Task<bool> DeleteBookingDetails(int id)
        {
            var delete =await _Db.BookingDetails.FindAsync(id);
            if (delete == null)
            {
                return false;
            }
            var deleted = _Db.BookingDetails.Remove(delete);
            _Db.SaveChanges();
            return true;

        }

        public async Task<BookingDetail> GetBookingDetails(string id)
        {
            var find = await _Db.BookingDetails.FindAsync(id);
            if (find == null)
                return null;
            return find;
        }

        public async Task<BookingDetail> GetBookingDetailsByEmail(string Email)
        {
            var find = await _Db.BookingDetails.FindAsync(Email);
            if (find == null)
                return null;
            return find;
        }


        public async Task<bool> UpdateBookingDetails(BookingDetail bookingDetail)
        {
            var update = await _Db.BookingDetails.FindAsync(bookingDetail.Email);
            if (update == null)
                return false;
            var updated = _Db.BookingDetails.Update(bookingDetail);
            return true;
        }
    }
}
