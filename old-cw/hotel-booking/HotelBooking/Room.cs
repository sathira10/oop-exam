namespace HotelBooking
{
    public abstract class Room : IComparable<Room>

    {
        // private attributes
        readonly int number;
        readonly int floor;
        double price;
        List<Reservation> reservations;

        // Getters and setters using C# properties

        public int Number {
            get { return number; }
        }

        public int Floor
        {
            get { return floor; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public List<Reservation> Reservations {
            get { return reservations; }
        }

        // constructor
        public Room(int number, int floor, double price)
        {
            this.number = number;
            this.floor = floor;
            this.price = price;
            reservations = new List<Reservation>();
        }

        // compare
        public int CompareTo(Room other)
        {
            return price.CompareTo(other.Price);
        }
    }


    // subclasses

    public class StandardRoom : Room
    {
        readonly int windows;

        public int Windows
        {
            get { return windows; }
        }

        public StandardRoom(int number, int floor, double price, int windows) : base(number, floor, price)
        {
            this.windows = windows;
        }
    }

    public class DeluxeRoom : Room
    {
        readonly double balconySize;

        public double BalconySize
        {
            get { return balconySize; }
        }

        public DeluxeRoom(int number, int floor, double price, double balconySize) : base(number, floor, price)
        {
            this.balconySize = balconySize;
        }
    }
}

