using Booking.Domain.Abstractions;

namespace Booking.Domain.Bookings;

public sealed class Booking : Entity
{
    public Booking(Guid id) : base(id)
    {
    }


}


