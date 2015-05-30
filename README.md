# UBERPointerizer
Application for tracking trips taken with UBER in a city

UBERPointerizer is an application for Windows that identifies trips taken with the UBER mobile app in a city.  This application mimics the UBER iPhone application and processes data sent back to the UBER app to estimate all the trips taken within a city.  There are two traits of the UBER API that allow this program to function.  First, the API returns identifiers for vehicles that are consistent and do not change from trip to trip, and that latitude and longitude of all the available vehicles in the city are published very often.

This application identifies trips taken by checking to see when cars become unavailable and then available again.  For example, a car becomes unavailable when you request a ride, however when you leave the vehicle, the car will become available again.  This program tracks these periods and the locations of the car and makes approximations to reverse engineer the starting location and ending location of the trip.

The program is early in development and is currently a hobby and proof-of-concept however it is fully functional and works out of the box.  Please excuse some dirty code that needs to be cleaned up.  The project can be imported to Visual Studio and all you have to do is press Build to start using UBERPointerizer.  If you find issues or have any suggestions or comments please feel free to let me know.

Features of UBERPointerizer:

•	Track trips taken in a city (start and end points for each trip)

•	View and generate heatmaps of free vehicles in a city

•	View and generate maps that show the exact paths of free vehicles in a city

•	View and generate maps that show all trips taken in a city

•	Export the raw coordinates, paths, headings, and time the data was collected for all UBER vehicles in a city

•	Export all identified trips for vehicles in a city

•	Collects data from UBER’s servers directly or you can import captures of the API through CharlesProxy, for example.

•	View all active vehicles and the exact latitude and longitude of each vehicle.

To use UBERPointerizer online you need to collect the device ID, UBER ID, the advertising ID, and session token.  This information is easily collected using an SSL proxy such as CharlesProxy.  Open the UBER app with the proxy running and the data can be collected from the request packet.  Since this application replicates the requests the iPhone application sends to UBER, this information is required.  If you are using an Android phone, some information and API requests might need to be changed.

How to use UBERPointerizer:

1.	Find your information using the info above.

2.	Click “Connect”

3.	If all is successful, the heatmap will appear and cab identifiers will begin appearing in the left-hand box.  You can slide the slider at the top to select the map that you would like to view.

	a.	If tracking has been running for a while the heatmap and route map will take a while to render.

4.	To look for trips that have been completed while the program was connected click “Perform Trip Analysis”

5.	The threshold values are the values that UBERPointerizer uses to classify a trip.  Good starter values are 0.5 miles and 120 seconds.  This will look for breaks in a vehicle’s update data that are longer than 2 minutes and further than half a mile apart.
6.	The number of trips will be updated at the bottom – you will not be able to view the “Trips” map until at least 1 trip is found.

	a.	It may take up to 100 (depending on the city) updates before a trip is identified.

7.	The data can be exported.  Press “Pause Tracking” then “Save Raw Data”.  This file can be imported later and viewed.

8.	If tracking is paused or you are viewing offline, you can click on a vehicle in the left-hand box and click “Open Inspector” which will open a window showing specific information for that vehicle including type of service (UberX, Black), all historical latitude and longitude information, and when it was first and last seen.

If you are importing an UBERPointerizer export file or are using raw API dumps you do not need the information stated above.

To open an import file, place it in the same directory as the UBERPointerizer executable and click import local file and click “Yes” when asked if it is an UBERPointerizer export file.  To open raw API dumps, each server response must be in its own text file and in a folder called “messages” for UBERPointerizer to recognize them.  It does not matter what the text files are called.

# Screenshots
![alt tag](http://mccardwell.net/extern/files/filehosting/static/upi/1.png)
![alt tag](http://mccardwell.net/extern/files/filehosting/static/upi/2.png)
![alt tag](http://mccardwell.net/extern/files/filehosting/static/upi/3.png)
![alt tag](http://mccardwell.net/extern/files/filehosting/static/upi/4.png)

This code is provided ‘as is’ for educational purposes and no warrantee is given.  Do not use this application for illegal purposes and I shall not be responsible for misuse.

This software is licensed under the MIT License.

This application uses components from the CefSharp library, which may be found at (including its license) at: https://github.com/cefsharp/CefSharp
