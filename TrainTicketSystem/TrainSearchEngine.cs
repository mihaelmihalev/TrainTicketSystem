using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketSystem
{
    public class TrainSearchEngine
    {

        private List<Train> trains;
        private Train train = new Train();
        public TrainSearchEngine(List<Train> trains)
        {
            this.trains = trains;
        }

        public List<Train> SearchTrainByDestination(string destination)
        {
            List<Train> matchingTrains = new List<Train>();
            foreach (Train train in trains)
            {
                if (train.Destination == destination)
                {
                    matchingTrains.Add(train);
                }
            }
            return matchingTrains;
        }

        public List<Train> SearchTrainByTime(DateTime departureTime)
        {
            List<Train> matchingTrains = new List<Train>();
            foreach (Train train in trains)
            {
                if (train.DepartureTime == departureTime)
                {
                    matchingTrains.Add(train);
                }
            }
            return matchingTrains;
        }
        public void FindTrainByDestination(string destination)
        {
            List<Train> matchingTrains = SearchTrainByDestination(destination);

            if (matchingTrains.Count > 0)
            {
                Console.WriteLine("Train(s) to {0} found:", destination);
                foreach (Train train in matchingTrains)
                {
                    Console.WriteLine(train);
                }
            }
            else
            {
                Console.WriteLine("No train found for destination {0}.", destination);
            }
        }

        public void FindTrainByDepartureTime(DateTime departureTime)
        {
            List<Train> matchingTrains = SearchTrainByTime(departureTime);

            if (matchingTrains.Count > 0)
            {
                Console.WriteLine("Train(s) at {0} found:", departureTime);
                foreach (Train train in matchingTrains)
                {
                    Console.WriteLine("Vlak " + train.Destination.ToString());
                }
            }
            else
            {
                Console.WriteLine("No trains found for {0}",departureTime);
            }
        }
    }
}

