using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using TrainTicketSystem;

namespace TrainTicketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for trains

            var trains = new List<Train>();
            trains.Add(new Train { Destination = "Sofia-Varna", DepartureTime = new DateTime(2023, 4, 29, 10, 0, 0) });
            trains.Add(new Train { Destination = "Sofia-Burgas", DepartureTime = new DateTime(2023, 4, 29, 11, 0, 0) });
            trains.Add(new Train { Destination = "Sofia-Plovdiv", DepartureTime = new DateTime(2023, 4, 29, 10, 30, 0) });

            // create the search engine
            var engine = new TrainSearchEngine(trains);

            // search for trains by destination
            engine.FindTrainByDestination("Sofia-Varna");
            engine.FindTrainByDestination("Sofia-Pernik");

            // search for trains by departure time
            engine.FindTrainByDepartureTime(new DateTime(2023, 4, 29, 10, 0, 0));
            engine.FindTrainByDepartureTime(new DateTime(2023, 4, 29, 12, 0, 0));

            // Users

            UserProfileManagmentSystem system = new UserProfileManagmentSystem();

            // Add a new user
            User user1 = new User { Username = "Admin", Role = "Admin" };
            system.AddUser(user1);

            // Edit an existing user
            User user2 = new User { Username = "User", Role = "User"};
            system.AddUser(user2);
            system.EditUser("Admin", user2);

            // View a user
            system.ViewUser("User");



        }
    }
}