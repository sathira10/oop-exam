namespace HotelBooking
{
    public interface IOverlappable
    {
        public bool Overlaps(Booking other);
    }

    public class Booking : IOverlappable
    {

        DateOnly startDate;
        DateOnly endDate;

        public DateOnly StartDate {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateOnly EndDate {
            get { return endDate; }
            set { endDate = value; }
        }

        public Booking(DateOnly pickupDate, DateOnly dropoffDate)
        {
            if (pickupDate > dropoffDate)
            {
                throw new ArgumentException("End date must be on or after the start date.");
            }
            startDate = pickupDate;
            endDate = dropoffDate;
        }

        public bool Overlaps(Booking other)
        {
            return !(endDate < other.StartDate || other.EndDate < startDate);
        }
    }


    public class Reservation
    {
        
        Booking schedule;

        public Booking Schedule {
            get { return schedule; }
        }

        public Reservation(Booking schedule)
        {
            this.schedule = schedule;
        }
    }
}

