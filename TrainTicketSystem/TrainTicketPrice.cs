using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketSystem
{
    public class TrainTicketPrice
    {
        public decimal CalculatePrice(int numberOfTickets, decimal basePrice, bool isTwoWay, TimeSpan departureTimeOfDay, bool hasCardForPeopleOverSixty, bool isWithChild, bool hasFamilyCard)
        {
            // Check if the departure time is during peak hours
            bool isPeakHours = (departureTimeOfDay >= TimeSpan.FromHours(7.5) && departureTimeOfDay <= TimeSpan.FromHours(9.5))
                || (departureTimeOfDay >= TimeSpan.FromHours(16) && departureTimeOfDay <= TimeSpan.FromHours(19.5));

            // Determine the discount based on various conditions
            decimal discount = 0m;

            if(!isPeakHours)
            {
                //moga da go mahna eventualno,ako ostane vreme

                if ((departureTimeOfDay >= TimeSpan.FromHours(9.5) && departureTimeOfDay <= TimeSpan.FromHours(16)) || departureTimeOfDay >= TimeSpan.FromHours(19.5))
                {
                    discount = 0.05m;
                }


                // Apply additional discounts based on the passenger type

                if (hasCardForPeopleOverSixty)
                {
                    discount += 0.34m;
                }

                if (isWithChild)
                {
                    discount += 0.10m;

                    if (hasFamilyCard)
                    {
                        discount += 0.4m;
                    }
                }

            }


            if (isTwoWay)
            {
                basePrice = basePrice * 2;
            }

            // Calculate the final price
            decimal finalPrice = numberOfTickets * basePrice * (1m - discount);
            return finalPrice;
        }

        public decimal CalculatePriceForTwoWay(decimal basePrice, bool isTwoWay)
        {
            decimal finalPrice;
            finalPrice = basePrice;

            if (isTwoWay)
            {
                finalPrice = basePrice * 2;
            }
            return finalPrice;
        }

    }
}
