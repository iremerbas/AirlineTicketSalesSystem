using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class DbContext
    {
        public static List<User> UserList = new List<User>();
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<Route> RouteList = new List<Route>();
        public static List<Plain> PlainList = new List<Plain>();
        public static List<Ticket> TicketList = new List<Ticket>();


        public DbContext()
        {
            Route route1 = new Route()
            {
                Id = 1,
                startPoint = "İstanbul",
                endPoint = "Ankara",

            };
            DbContext.RouteList.Add(route1);




            Route route2 = new Route()
            {
                Id = 2,
                startPoint = "İstanbul",
                endPoint = "Rize",

            };
            DbContext.RouteList.Add(route2);




            Route route3 = new Route()
            {
                Id = 3,
                startPoint = "Ankara",
                endPoint = "İstanbul",

            };
            DbContext.RouteList.Add(route3);




            Route route4 = new Route()
            {
                Id = 4,
                startPoint = "Ankara",
                endPoint = "Rize",

            };
            DbContext.RouteList.Add(route4);


            Route route5 = new Route()
            {
                Id = 5,
                startPoint = "Rize",
                endPoint = "Ankara",

            };
            DbContext.RouteList.Add(route5);



            Route route6 = new Route()
            {
                Id = 6,
                startPoint = "Rize",
                endPoint = "İstanbul",

            };
            DbContext.RouteList.Add(route6);




            Plain plain1 = new Plain()
            {
                Id = 1,
                RouteID = 1,
                DepertureTime = "15:00",
                seatPiece = 30,
                Price = 599.99
            };
            PlainList.Add(plain1);
            Plain plain2 = new Plain()
            {
                Id = 2,
                RouteID = 1,
                DepertureTime = "18:00",
                seatPiece = 30,
                Price = 649.99
            };
            PlainList.Add(plain2);
            Plain plain3 = new Plain()
            {
                Id = 3,
                RouteID = 1,
                DepertureTime = "21:00",
                seatPiece = 30,
                Price = 699.99
            };
            PlainList.Add(plain3);

            Plain plain4 = new Plain()
            {
                Id = 4,
                RouteID = 2,
                DepertureTime = "12:00",
                seatPiece = 30,
                Price = 899.99
            };
            PlainList.Add(plain4);
            Plain plain5 = new Plain()
            {
                Id = 5,
                RouteID = 2,
                DepertureTime = "16:00",
                seatPiece = 30,
                Price = 949.99
            };
            PlainList.Add(plain5);
            Plain plain6 = new Plain()
            {
                Id = 6,
                RouteID = 2,
                DepertureTime = "22:00",
                seatPiece = 30,
                Price = 999.99
            };
            PlainList.Add(plain6);

            Plain plain7 = new Plain()
            {
                Id = 7,
                RouteID = 3,
                DepertureTime = "13:00",
                seatPiece = 30,
                Price = 599.99
            };
            PlainList.Add(plain7);
            Plain plain8 = new Plain()
            {
                Id = 8,
                RouteID = 3,
                DepertureTime = "17:00",
                seatPiece = 30,
                Price = 649.99
            };
            PlainList.Add(plain8);
            Plain plain9 = new Plain()
            {
                Id = 9,
                RouteID = 3,
                DepertureTime = "20:00",
                seatPiece = 30,
                Price = 699.99
            };
            PlainList.Add(plain9);


            Plain plain10 = new Plain()
            {
                Id = 10,
                RouteID = 4,
                DepertureTime = "09:00",
                seatPiece = 30,
                Price = 749.99
            };
            PlainList.Add(plain10);
            Plain plain11 = new Plain()
            {
                Id = 11,
                RouteID = 4,
                DepertureTime = "14:00",
                seatPiece = 30,
                Price = 799.99
            };
            PlainList.Add(plain11);
            Plain plain12 = new Plain()
            {
                Id = 12,
                RouteID = 4,
                DepertureTime = "19:00",
                seatPiece = 30,
                Price = 849.99
            };
            PlainList.Add(plain12);

            Plain plain13 = new Plain()
            {
                Id = 13,
                RouteID = 5,
                DepertureTime = "08:00",
                seatPiece = 30,
                Price = 749.99
            };
            PlainList.Add(plain13);
            Plain plain14 = new Plain()
            {
                Id = 14,
                RouteID = 5,
                DepertureTime = "11:00",
                seatPiece = 30,
                Price = 849.99
            };
            PlainList.Add(plain14);
            Plain plain15 = new Plain()
            {
                Id = 15,
                RouteID = 5,
                DepertureTime = "23:00",
                seatPiece = 30,
                Price = 899.99
            };
            PlainList.Add(plain15);

            Plain plain16 = new Plain()
            {
                Id = 16,
                RouteID = 6,
                DepertureTime = "08:00",
                seatPiece = 30,
                Price = 949.99

            };
            PlainList.Add(plain16);
            Plain plain17 = new Plain()
            {
                Id = 17,
                RouteID = 6,
                DepertureTime = "15:00",
                seatPiece = 30,
                Price = 999.99
            };
            PlainList.Add(plain17);
            Plain plain18 = new Plain()
            {
                Id = 18,
                RouteID = 6,
                DepertureTime = "19:00",
                seatPiece = 30,

                Price = 1049.99
            };
            PlainList.Add(plain18);




            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Sema",
                Surname = "Kanbur",
                Balance = 10000000,
                TC = "12345678912"
            };
            CustomerList.Add(customer1);

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Alev",
                Surname = "Kutnay",
                Balance = 1000,
                TC = "23456789123"
            };
            CustomerList.Add(customer2);

















        }


    }



}
