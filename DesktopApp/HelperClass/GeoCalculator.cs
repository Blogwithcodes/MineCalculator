using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.HelperClass
{

    public static class GeoCalculator
    {
        private const double EarthRadius = 6371e3;


        public static (double newLatitude, double newLongitude) CalculateNextPoint(double currentLatitude, double currentLongitude, double distance, double bearing)
        {
            // Convert latitude and longitude from degrees to radians
            double lat1 = DegreesToRadians(currentLatitude);
            double lon1 = DegreesToRadians(currentLongitude);
            double brng = DegreesToRadians(bearing);

            // Calculate the next point's latitude
            double lat2 = Math.Asin(Math.Sin(lat1) * Math.Cos(distance / EarthRadius) +
                                    Math.Cos(lat1) * Math.Sin(distance / EarthRadius) * Math.Cos(brng));

            // Calculate the next point's longitude
            double lon2 = lon1 + Math.Atan2(Math.Sin(brng) * Math.Sin(distance / EarthRadius) * Math.Cos(lat1),
                                            Math.Cos(distance / EarthRadius) - Math.Sin(lat1) * Math.Sin(lat2));

            // Normalize the longitude to be within the range -180 to 180 degrees
            lon2 = (lon2 + 3 * Math.PI) % (2 * Math.PI) - Math.PI;

            // Convert the result from radians to degrees
            double newLatitude = RadiansToDegrees(lat2);
            double newLongitude = RadiansToDegrees(lon2);

            return (newLatitude, newLongitude);
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        private static double RadiansToDegrees(double radians)
        {
            return radians * (180 / Math.PI);
        }
    }
    public static class GeoValidator
    {
        public static bool IsValidLatitude(double latitude)
        {
            return latitude >= -90 && latitude <= 90;
        }

        public static bool IsValidLongitude(double longitude)
        {
            return longitude >= -180 && longitude <= 180;
        }

        public static bool IsValidCoordinates(double latitude, double longitude)
        {
            return IsValidLatitude(latitude) && IsValidLongitude(longitude);
        }
    }
}