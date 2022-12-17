using Hotel_API.Data;
using Hotel_API.Entities;

namespace Hotel_API.Repository.Interface
{
    public interface IBookingDetailsRepository
    {

        Task<BookingDetail> GetBookingDetails(string id);
        Task<bool> UpdateBookingDetails(BookingDetail bookingDetail);
        Task<bool> DeleteBookingDetails(int id);
        Task<BookingDetail> CreateBooking(BookingDetail bookingDetail);
        Task<BookingDetail> GetBookingDetailsByEmail(string Email);
    }
}
