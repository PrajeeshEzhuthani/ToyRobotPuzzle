# ToyRobotPuzzle
Coding test for Hooroo
The puzzle is done using Viual Studio 2017 and it consists of 5 Projects
Robot.Model - Class Library application - holds the domain model 

ToyRbot.Services - Processing logic is handled in this service 

ToyRobot.Web - The web application provides a simple UI to enter the commads and the results are displayed here 
              Insructions are consructed as a defined models and it is pass on to the Service layer to process 
              
ToyRobot.MockConsole - Initial logic for processing the commads are constructed here . Used for quick trial and error.
                         Once the desired outputs are dislayed , the application logic is moved to the Service project
                         This project is not required to run the application - it served more like a sandbox 
ToyRobotPuzzle.Tests  - Unit test project 


Instructions to execute the application

Open the solution file in Visual Studio 
Set the ToyRobot.Web as the start up project 
Run the ToyRobot.Web project (F5)

NOTE : 
I have tried Minimum Viabe Product approach . In the current implementation I have tried to achieve the basic requirements 
Few improvements that I would like to implement in lates stages are 
1.Dependancy Injection
2.Input Validation in Front End (Javascript) 
3.Move the service layer to WebApi (With Swagger end points)
4.ore unit test to cover all the scenarios 


                        
