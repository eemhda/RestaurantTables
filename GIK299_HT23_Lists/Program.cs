namespace GIK299_HT23_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RestaurantTable> restaurantTables = new List<RestaurantTable>();

            int tableNumber = 1;
            int numberOfSeats = 4;
            Reservation reservationStatus = Reservation.NotReserved;
            RestaurantTable table = new RestaurantTable(tableNumber, numberOfSeats, reservationStatus);
            restaurantTables.Add(table);
            table.SeatGuests(true);
            table.TakeOrder();


            RestaurantTable table2 = new RestaurantTable(2, 6, Reservation.Reserved);
            table2.SeatGuests(true);
            table2.TakeOrder();
            restaurantTables.Add(table2);

            RestaurantTable table3 = new RestaurantTable(3, 2, Reservation.NotReserved);
            table3.SeatGuests(false);
            restaurantTables.Add(table3);
             
   
            foreach (var restaurantTable in restaurantTables)
            {
                Console.WriteLine("Table number: " + restaurantTable.TableNumber);
                Console.WriteLine("Number of seats: " + restaurantTable.NumberOfSeats);
                Console.WriteLine("Reservation status: " + restaurantTable.ReservationStatus);
                Console.WriteLine("Is seated: " + restaurantTable.IsSeated);
                Console.WriteLine("Ordered drinks: ");
                foreach (var drink in restaurantTable.OrderedDrinks)
                {
                    Console.WriteLine(drink);
                }
                Console.WriteLine("Ordered food: ");
                foreach (var food in restaurantTable.OrderedFood)
                {
                    Console.WriteLine(food);
                }
                Console.WriteLine("===================================");
            }
        }
    }
}