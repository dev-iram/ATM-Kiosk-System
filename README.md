# ATM-Kiosk-System Modern Bank 
![ATM Kiosk System](https://user-images.githubusercontent.com/22479692/123785107-0e523d80-d8d0-11eb-8bf2-95c8dec60a9d.png)

 This is a project I created as per specifications in C&amp;G Event Driven programming module during the course of my FIT ICTAP Software Development apprenticeship.    
   
 ✦ Programming Language; C# (Help System using HTML, CSS + Bootstrap)  
 ✦ Framework; .NET Framework  
 ✦ Software Tools;  
    &nbsp;&nbsp;&nbsp;&nbsp;✧ Microsoft Visual Studio: Used for the creation of the ATM Kiosk System and the Graphical User Interface  
    &nbsp;&nbsp;&nbsp;&nbsp;✧ DB Browser: Used to populate and view database tables. Management of the database used in the system  
    &nbsp;&nbsp;&nbsp;&nbsp;✧ SQlite: Entry level free database   
    &nbsp;&nbsp;&nbsp;&nbsp;✧ Packages: NuGet SQLite Packages and Entity Framework installed on Visual Studio required to connect Database to the System  
   
 
## Assignment Brief  
  
A bank has been developing a simple login system allowing their customer to log into the system and check their current balance. This system however is outdated and does not provide much response to the user’s current errors or invalid entries. A project has been commissioned to further this application to better inform the user.  
  
Design a piece of software using event driven programming solution that identifies the components, data/file structures, makes effective use of the Integrated Development Environment and incorporates onscreen help for users (e.g. Error messages, end user guidance). The design components can include any of the following:  
  
✦ public  
✦ private  
✦ protected  
✦ text boxes  
✦ combo boxes  
✦ list boxes  
✦ check boxes  
✦ radio buttons  
✦ listeners  
✦ exceptions  
✦ projects  
✦ classes  
✦ variables  
✦ strings  
✦ arrays  
✦ images  
  
    
### Project Requirements  
  
The project requirements involve the creation of a C#, .NET Framework application using an Object-Oriented Event-Driven programming approach that is to be used as an ATM Kiosk for Modern Bank.    
  
The requirements and methods that Modern Bank would like to be featured within the scope of this application includes:    
  
  ✦	Login System – Using the Account Number and Account Pin to act as a username and password to the system. 
  ✦	View Current Balance – Allowing the customer to see their current balance on screen  
  ✦	View and Edit Personal Details – Allow the customer to see their current details, and make amendments where required.  
  ✦	View Banking Details – Allowing the customer to view private banking details, such as Account Number, Account PIN and Balance.  
  ✦	Transfer – Ability to transfer money from one account to another  
  ✦	Transaction History – Allow the user to view their transaction history, display their in/out funds with a description  
  ✦	Timer – A timer that will log the user out after a certain amount of time  
  ✦	Events – At least 3 different event types to be implemented within the program, 
e.g. Timer, onMouseOver, onHover, onCheck, etc.  
  ✦	Database to store customer’s account number, account pin, balance, address, name, etc. Multiple tables within the database.   
  ✦	ATM Connector Class – A class for all SQL query’s within the system  
  
### Functionality  
    
  ✦	The system will begin with a screen that acts like a screensaver. It will require the user to click anywhere to load the system. This will open the Login screen.  
  ✦	The user will be prompted to Login. The customer must use their credentials already created via the bank. They will be able to access the system using their Account Number and Account PIN. They must use the onscreen keypad in order to login.  (Please see *Testing* for credentials)
  ✦	After a successful login, the ATM Kiosk system will bring the customer to the main screen which will feature the different options and functionality of the system. This page will also feature a welcome message with the user’s first name.  
  ✦	The customer will have the ability to click a button to view their balance. This will open a new screen that will display the current funds in their bank account.  
  ✦	The customer will have the ability to change their current PIN. Their current PIN must first be confirmed, and then the system will allow the user to input a new pin which also requires a confirmation and to be entered twice.  
  ✦	The customer will have the ability to view and edit their personal details. They will also be able to view their banking details.   
  ✦	The user will have the ability to Add a Payee, that can be used later to transfer funds.  
  ✦	The customer will have the option to transfer funds from one account to another.  
  ✦	The customer will have the option to view their transaction history.  
  ✦	The customer will have the option to exit the program.  
  ✦	A timer will be present within the system that will enable a session to timeout.  


## Testing 

### Credentials for testing: 
✦ Username: 12345678   
✦ Password: 1234  
Please note: When logging in, the login is "touch", so you can use the buttons on the screen!  
It will automatically move to the next input box after you have entered the username.  
Hovering over the boxes will clear its contents.  


##### Please see documentation in repo for additional information regarding the system, including screenshots + diagrams. 







