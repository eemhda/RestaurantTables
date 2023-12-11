using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_HT23_Lists
{
    public  class RestaurantTable
    {
        public int TableNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public Reservation ReservationStatus { get; set; }
        public bool IsSeated { get; set; }

        public List<string> OrderedDrinks { get; set; }
        public List<string> OrderedFood { get; set; }

        public RestaurantTable(int tableNumber, int numberOfSeats, Reservation reservationStatus)
        {
            TableNumber = tableNumber;
            NumberOfSeats = numberOfSeats;
            ReservationStatus = reservationStatus;
            OrderedDrinks = new List<string>();
            OrderedFood = new List<string>();
        }

        public void TakeOrder()
        {
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("What would you like to order?");
                Console.WriteLine("1. Food");
                Console.WriteLine("2. Drinks");
                Console.WriteLine("3. Both");
                Console.WriteLine("4. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //getting food order with error handling
                        Console.WriteLine("What food would you like to order?");
                        string food = Console.ReadLine();
                        OrderedFood.Add(food);
                        break;
                    case 2:
                        Console.WriteLine("What drink would you like to order?");
                        string drink = Console.ReadLine();
                        OrderedDrinks.Add(drink);
                        break;
                    case 3:
                        Console.WriteLine("What food would you like to order?");
                        string food2 = Console.ReadLine();
                        OrderedFood.Add(food2);
                        Console.WriteLine("What drink would you like to order?");
                        string drink2 = Console.ReadLine();
                        OrderedDrinks.Add(drink2);
                        break;
                    case 4:
                        Console.WriteLine("Ordered completed\n\n");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please enter");
                        break;
                }
            }
        }

        public void PrintOrder()
        {
            Console.WriteLine($"\nOrder for table : {TableNumber}");


            Console.WriteLine($"Food: for table: {TableNumber}");
            foreach (var food in OrderedFood)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine($"Drinks for table: {TableNumber}");
            foreach (var drink in OrderedDrinks)
            {
                Console.WriteLine(drink);
            }
            Console.WriteLine("-----------------------------");
        }

        public void ClearTable() // Clears the table and sets the reservation status to NotReserved
        {
            OrderedDrinks.Clear();
            OrderedFood.Clear();
            ReservationStatus = Reservation.NotReserved;
        }

        public bool SeatGuests(bool isSeated) // Sets the IsSeated property to true
        {
            if (isSeated)
            {
                IsSeated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
