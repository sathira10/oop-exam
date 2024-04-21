namespace HotelBooking
{
    public interface IHotelManager
    {
        public bool AddRoom(Room room);
        //public bool DeleteRoom(int roomNumber);
        //public void ListRooms();
        //public void ListRoomsOrderedByPrice();
        //public void GenerateReport(string fileName);
    }

    public interface IHotelCustomer
    {
        //public void ListAvailableRooms(Booking wantedBooking);
        //public void ListAvailableRooms(Booking wantedBooking, int maxPrice);
        //public bool AddReservation(int roomNumber, Booking wantedBooking);
    }


    public class WestminsterHotel : IHotelManager, IHotelCustomer
    {

        List<Room> roomList;

        public List<Room> RoomList {
            get { return roomList; }
        }

        public WestminsterHotel()
        {
            roomList = new List<Room>();
        }

        public bool AddRoom(Room room)
        {
            // Check if the room number exists
            if (roomList.Exists(v => v.Number == room.Number))
            {
                Console.WriteLine("Room number already exists.");
                return false;
            }
            roomList.Add(room);
            return true;           
  
        }

    }

}

