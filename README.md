DESCRIPTION

Simple test framework for the OpenWeatherAPI service to check for current weather details

STEP BY STEP API TESTING GUIDE

1.	Install packages:
•	Newtonsoft.Json
•	NUnit
•	Nunit3TestAdapter
•	RestSharp

2.	Create an app.config, with details for the URL for the API as well as personal access key.

3.	Data handling: Takes the API request and creates a data model similar to database layers
Every time a request is made it will get and set each data from the API. Data handling is a class for the API layer.

4.	Database model can be created via Postman. Run an API request and copy the returned JSON data. Within Visual Studios create a new Weather Model. In the Edit navigation tab, you can paste special the JSON data as classes.

5.	HTTP manager is a class used to initialize the rest sharp request

6.	Unit tests

SETUP

To setup the project for your own system visit https://openweathermap.org and create an account. Once created navigate to app.config and update the API key with your own access key which you should have received via email. 
Ensure that the following NuGet packages are installed and rebuild your project.
•	Newtonsoft.Json
•	NUnit
•	Nunit3TestAdapter
•	RestSharp

Within your weather call manager class, you can update and change the rest request for the location that you are testing. The current default location that is set is London. Replace this with a location of your choice within the GetCurrentWeather() method.
Using the Open Weather API with your own requests you can go to Postman and use a get request with the following URL http://api.openweathermap.org/data/2.5/weather?q={LOCATION}&appid={API KEY}. By modifying with a location of your choice and your own access key you will be able to create your own Unit Test with the framework.

RETROSPECTIVE
The project has taught me how to create a simple C# test framework to test for specific requests from an API. I faced quite a few errors and difficulties with the project. For instance, there was a defect within AppConfigReader class when declaring using System.Configuration namespace, the configuration manager would still return an error so the developer would need to run potential fixes to resolve. Due to what I have learnt I would be able to recreate the project quickly for a separate API through reverse engineering the code. A potential improvement in the future is that due to the fact that all the tests and requests are hardcoded the program is not automated. As I have not experienced automating the API request via the C# application the unit tests would have to be written based on the location specified in the  Weather Call Manager class.

KEY WORDS
A Data Transfer Object is an object that is used to encapsulate data, and send it from one subsystem of an application to another.
DTOs are most commonly used by the Services layer in an N-Tier application to transfer data between itself and the UI layer. The main benefit here is that it reduces the amount of data that needs to be sent across the wire in distributed applications. They also make great models in the MVC pattern.
