using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBERPOINTERIZER
{
    public class MapMaker
    {
        public static double bostonLat = 42.339525, bostonLon = -71.090456;
        public static double nycLat = 40.698107, nycLon = -73.986547;
        public static double providenceLat = 41.828250, providenceLon = -71.410537;

        private static String[] colors = new String[] {"#1E90FF","#B22222","#228B22","#FFFF00","#FFFFF0", "#000000"};

        private static String topHeatMap = " <!DOCTYPE html> <html> <head> <meta charset=\"utf-8\"> <title>Heatmaps</title> <style> html, body, #map-canvas { height: 100%; margin: 0px; padding: 0px } #panel { position: absolute; top: 5px; left: 50%; margin-left: -180px; z-index: 5; background-color: #fff; padding: 5px; border: 1px solid #999; } </style> <script src=\"https://maps.googleapis.com/maps/api/js?v=3.exp&signed_in=true&libraries=visualization\"></script> <script> var map, pointarray, heatmap; var taxiData = [";
        private static String twoHeatMap = "];function initialize() {var mapOptions = {zoom: 13, center: new google.maps.LatLng(";
        private static String threeHeatMap = "), mapTypeId: google.maps.MapTypeId.ROADMAP }; map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions); var pointArray = new google.maps.MVCArray(taxiData); heatmap = new google.maps.visualization.HeatmapLayer({ data: pointArray }); heatmap.setMap(map); } function toggleHeatmap() { heatmap.setMap(heatmap.getMap() ? null : map); } function changeGradient() { var gradient = [ 'rgba(0, 255, 255, 0)', 'rgba(0, 255, 255, 1)', 'rgba(0, 191, 255, 1)', 'rgba(0, 127, 255, 1)', 'rgba(0, 63, 255, 1)', 'rgba(0, 0, 255, 1)', 'rgba(0, 0, 223, 1)', 'rgba(0, 0, 191, 1)', 'rgba(0, 0, 159, 1)', 'rgba(0, 0, 127, 1)', 'rgba(63, 0, 91, 1)', 'rgba(127, 0, 63, 1)', 'rgba(191, 0, 31, 1)', 'rgba(255, 0, 0, 1)' ]; heatmap.set('gradient', heatmap.get('gradient') ? null : gradient); } function changeRadius() { heatmap.set('radius', heatmap.get('radius') ? null : 20); } function changeOpacity() { heatmap.set('opacity', heatmap.get('opacity') ? null : 0.2); } google.maps.event.addDomListener(window, 'load', initialize); </script> </head> <body> <div id=\"panel\"> <button onclick=\"toggleHeatmap()\">Toggle Heatmap</button> <button onclick=\"changeGradient()\">Change gradient</button> <button onclick=\"changeRadius()\">Change radius</button> <button onclick=\"changeOpacity()\">Change opacity</button> </div> <div id=\"map-canvas\"></div> </body> </html>";

        private static String oneRouteMap = "<!DOCTYPE html> <html> <head> <meta charset=\"utf-8\"> <title>Heatmaps</title> <style> html, body, #map-canvas { height: 100%; margin: 0px; padding: 0px } #panel { position: absolute; top: 5px; left: 50%; margin-left: -180px; z-index: 5; background-color: #fff; padding: 5px; border: 1px solid #999; } </style> <script src=\"https://maps.googleapis.com/maps/api/js?v=3.exp&signed_in=true&libraries=visualization\"></script> <script> function initialize() {var mapOptions = {zoom: 13, center: new google.maps.LatLng(";
        private static String twoRouteMap = "), mapTypeId: google.maps.MapTypeId.HYBRID }; var map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);";
        private static String threeRouteMap = " } google.maps.event.addDomListener(window, 'load', initialize); </script> </head> <body> <div id=\"map-canvas\"></div> </body> </html>";

        public static String getHeatMapRequest(List<Cab> visibleCabs, double centerLat, double centerLon)
        {
            String cabList = "";

            for (int i = 0; i < visibleCabs.Count(); i++)
            {
                Cab currentCab = visibleCabs[i];
                for (int ix = 0; ix < currentCab.epoch.Count(); ix++)
                {
                    cabList += "new google.maps.LatLng(" + currentCab.lat[ix] + "," + currentCab.lon[ix] + "),";
                }
            }
            cabList = cabList.Remove(cabList.Length - 1);
            return topHeatMap + cabList + twoHeatMap + centerLat + "," + centerLon + threeHeatMap;
        }

        public static String getRouteMapRequest(List<Cab> visibleCabs, double centerLat, double centerLon)
        {
            String pointArrays = "";
            for (int i = 0; i < visibleCabs.Count(); i++)
            {
                Cab currentCab = visibleCabs[i];
                if (currentCab.epoch.Count == 0) { continue; }
                pointArrays += "\nvar d" + i + "=[";
                for (int ix = 0; ix < currentCab.epoch.Count(); ix++)
                {
                    pointArrays += "new google.maps.LatLng(" + currentCab.lat[ix] + "," + currentCab.lon[ix] + "),";
                }
                pointArrays = pointArrays.Remove(pointArrays.Length - 1);
                pointArrays += "];\nvar p" + i + "=new google.maps.Polyline({path: d" + i + ", strokeColor: ";
                int cIndex = i;
                while (cIndex > (colors.Count() - 1)) { cIndex -= colors.Count(); }
                pointArrays += "\"" + colors[cIndex] + "\", strokeOpacity: 1.0, strokeWeight: 2 }); p" + i + ".setMap(map); ";
            }
            Console.WriteLine("\nRoute string generated - " + visibleCabs.Count + " cabs");
            return oneRouteMap + centerLat + "," + centerLon + twoRouteMap + pointArrays + threeRouteMap;
        }

        public static String getTrendMapRequest(List<Trip> trips, double centerLat, double centerLon)
        {
            String pointArrays = "";
            for (int i = 0; i < trips.Count(); i++)
            {
                pointArrays += "\n var d" + i + "=[";
                pointArrays += " new google.maps.LatLng(" + trips[i].startLat + "," + trips[i].startLon + "),";
                pointArrays += " new google.maps.LatLng(" + trips[i].endLat + "," + trips[i].endLon + ")";
                pointArrays += "]; \n var p" + i + " = new google.maps.Polyline({path: d" + i + ", strokeColor: ";
                int cIndex = i;
                while (cIndex > (colors.Count() - 1)) { cIndex -= colors.Count(); }
                pointArrays += "\"" + colors[cIndex] + "\", strokeOpacity: 1.0, strokeWeight: 4 }); p" + i + ".setMap(map); ";
                pointArrays += " var ms" + i + " = new google.maps.Marker({ position: new google.maps.LatLng("+trips[i].startLat+","+trips[i].startLon+"), map: map, icon: 'http://maps.google.com/mapfiles/ms/icons/green-dot.png', title:\""+ trips[i].cabIdentifier +" START\"}); ms"+i+".setMap(map);";
                pointArrays += " var me" + i + " = new google.maps.Marker({ position: new google.maps.LatLng(" + trips[i].endLat + "," + trips[i].endLon + "), map: map, icon: 'http://maps.google.com/mapfiles/ms/icons/red-dot.png', title:\"" + trips[i].cabIdentifier + " END\"}); me" + i + ".setMap(map);";
            }

            return oneRouteMap + centerLat + "," + centerLon + twoRouteMap + pointArrays + threeRouteMap;
        }
    }
}
