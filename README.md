Overview 
To automate REST API framework I have used   
•	Specflow – supports behavior driven development (BDD) 
•	In order to consume web API I have user Rest Sharp library open source. 

Advantages of this Framework 
•	Developers can use it for unit testing. 
•	BDD framework allows the whole team to understand and participate in test/dev actively. 
•	Improves testing  

This framework covers these scenarios 
1.	Get Valid request 
2.	Post valid Request 
3.	Put request to validate a user 
4.	Create a new user request
5.	Get Invalid request

Framework Structure 
I have Created 2 projects to run the tests.
•	ReqRes API Tests project – Feature files and step definitions are under this folder
•	Common Library Project – Added RestAPIHelper library under this project which references the Api Tests Project.
•	
Further Improvements
. Added Reports folder and created a new Hooks.cs file. Purpose of adding this here is to get reports after the tests finish executing. This class is helpful to create reports. By simply calling the Methods we use.
. For this I have added extent reports library to create Reports in working Directory. (further improvement)

App Config
.I have added app config for future in order to run tests on different environments.
