Kevin Tsao
Pokemon Go Tracker

Originally Project #2: Commercially Viable Application
for CS480: Database Systems
Relational databases, N-tier architecture, SQL, C#

This was the final assignment for CS480: Databases and a group project. The proposal was to design the concept for a commercially viable application on any platform and then create a working prototype of the idea on an three-tier architecture design using C# and SQL. My group partner was Jaskaran Singh, and our idea was to create a companion application to the mobile game Pokemon Go.

In the game Pokemon Go, ingame creatures known as Pokemon spawn at random, real-world locations. These are then captured by the players, who must physically navigate to those locations. 151 Pokemon are represented in the game at the time of the creation of this program, and there exists a complex series of mechanics within the game differentiating them based on certain data such as level and elemental affinity. These are all tracked accordingly in our program.

The purpose of our app was to create a crowdsourced database of all Pokemon currently captured, and then provide players with a mechanism to view the data on those captures mapping to their physical, real-world locations of incidence. Ideally, we would design an API to tap into the Niantic servers and the player's mobile devices, thus feeding data into our app on a realtime basis, but this is obviously impossible. Instead, our data consisted of randomly generated Excel spreadsheets.

The presentation tier was written in C# and the logic tier written in SQL. The functionality of our completed program is as follows:

1. Create a listing of all 151 Pokemon in the game, and store relevant data such as name and typing.
2. Create a database of trainers, the Pokemon on those trainers' rosters, and their relevant data.
3. Store all locations in the world where the listed Pokemon have been caught, rank locations by catch frequency, and display relevant information to user. 
4. Allow user to view own data by entering in account information and accessing database. 
5. Allow user to update database by entering in details about recently caught Pokemon. 
6. Create a listing of Pokemon Go gyms in the world and display their current defending Pokemon. 
7. Allow users to update database by capturing gyms and replacing the defending Pokemon.
8. Multi-User support to allow multiple users to update at the same time using transactional queries.

My partner Jaskaran Singh handled the connection code and set up our server using Microsoft Azure. I designed and wrote the GUI in C# and came up with the concept and features. The SQL code was a team effort. Given more time and resources, as well as official support from the developer Niantic, we had more proposed features such as a real-time "recently caught" news feed and an alert function that allowed players to select a Pokemon they want and then message them as soon as that Pokemon was caught anywhere.