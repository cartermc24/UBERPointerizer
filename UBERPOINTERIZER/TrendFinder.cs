using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBERPOINTERIZER
{
    static class TrendFinder
    {
        public static List<Trip> identifyTripByPickupDropoff(List<Cab> visibleCabs, long timeThreshold, Double distThreshold)
        {
            List<Trip> trips = new List<Trip>();

            for (int i = 0; i < visibleCabs.Count(); i++)
            {
                Cab currentCab = visibleCabs[i];
                for (int ix = 0; ix < (currentCab.epoch.Count() - 1); ix++)
                {
                    Double dist = distance(currentCab.lat[ix], currentCab.lon[ix], currentCab.lat[ix + 1], currentCab.lon[ix + 1], 'm');
                    dist = Math.Abs(dist);
                    if (dist > distThreshold && (currentCab.epoch[ix+1]-currentCab.epoch[ix]) > (timeThreshold))
                    {
                        //Console.WriteLine("Trip Found!: CabID: " + currentCab.cabIdentifier + " dist: " + dist + " durat: " + (currentCab.epoch[ix + 1] - currentCab.epoch[ix])); //For more detailed information DEBUG
                        Trip t = new Trip();
                        t.cabIdentifier = currentCab.cabIdentifier;
                        t.tripDuration = (currentCab.epoch[ix + 1] - currentCab.epoch[ix]);
                        t.startLat = currentCab.lat[ix];
                        t.startLon = currentCab.lon[ix];
                        t.endLat = currentCab.lat[ix + 1];
                        t.endLon = currentCab.lon[ix + 1];
                        t.distance = dist;
                        trips.Add(t);
                    }
                }
            }

            return trips;
        }

        private static Double distance(double lat1, double lon1, double lat2, double lon2, char unit)
        {
            Double theta = lon1 - lon2;
            Double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            if (unit == 'K')
            {
                dist = dist * 1.609344;
            }
            else if (unit == 'N')
            {
                dist = dist * 0.8684;
            }
            return (dist);
        }

        private static Double deg2rad(Double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private static Double rad2deg(Double rad)
        {
            return (rad / Math.PI * 180.0);
        }
    }
}
