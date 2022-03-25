using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerators
{
    public class CabInvoiceGenerator
    {
        const int COST_PER_KM = 10;
        const int COST_PER_MINUTE = 1;
        const int MINIMUM_FAIR = 5;
        List<Ride> rides = new List<Ride>();

        public double CalculateFair(double distance, int time)
        {
            var fair = (distance * COST_PER_KM) + (time * COST_PER_MINUTE);
            if (fair > MINIMUM_FAIR)
            {
                return fair;
            }
            return MINIMUM_FAIR;
        }
        public void AddRide(double distance, int time)
        {
            rides.Add(new Ride()
            {
                distance = distance,
                time = time
            });
        }

        public double CalculateAggregate()
        {
            double fair = 0;
            IEnumerable<Ride> rides = null;
            foreach (Ride ride in rides)
            {
                fair += CalculateFair(ride.distance, ride.time);
            }
            return fair;
        }
    }
}
