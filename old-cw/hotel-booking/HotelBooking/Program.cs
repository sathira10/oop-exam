namespace HotelBooking
{
    class Program
    {
        static void Main()
        {

            // SOME TESTS TO SEE IF THE CODE WORKS AS EXPECTRED


            Booking b1 = new(new DateOnly(2024, 3, 3), new DateOnly(2024, 3, 5)); // 3rd - 5th
            Booking b2 = new(new DateOnly(2024, 3, 4), new DateOnly(2024, 3, 7)); // 4rd - 7th
            Booking b3 = new(new DateOnly(2024, 3, 6), new DateOnly(2024, 3, 7)); // 6rd - 7th

            // overlapping bookings
            bool result1 = b1.Overlaps(b2);

            if (result1)
            {
                Console.WriteLine("OK - Overlapping bookings are properly detected");
            }
            else
            {
                Console.WriteLine("ERROR - Overlapping bookings not detected");

            }

            // non overlapping bookings
            bool result2 = !b1.Overlaps(b3);

            if (result2)
            {
                Console.WriteLine("OK - Non Overlapping bookings are properly handled");
            }
            else
            {
                Console.WriteLine("ERROR - Non Overlapping bookings show as overlapping");

            }

            // Room tests

            Room r1 = new StandardRoom(457, 4, 10000, 2);
            Room r2 = new StandardRoom(457, 5, 80000, 3); // duplicate room number

            WestminsterHotel system = new();

            // add a room
            bool result3 = system.AddRoom(r1);

            if (result3)
            {
                Console.WriteLine("OK - Successfully added room");
            }
            else
            {
                Console.WriteLine("ERROR - Can't add room");

            }

            // add duplicate room number
            bool result = system.AddRoom(r2);

            if (!result)
            {
                Console.WriteLine("OK - Blocked duplicate room");
            }
            else
            {
                Console.WriteLine("ERROR - Added duplicate room");


            }
        }
    }
}