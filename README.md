# DotNetCoreDemoWebApiApplication

You are asked to create a JavaScript web application and C# REST API back end. 
The JavaScript client is to have a responsive UI and display appropriately on desktop and mobile device browsers.

The application is to display a list of book titles when launched. The book list is to be loaded from a database. 
No other book operations (delete, update, etc.) or book data (e.g. price) are necessary. 
The user can select a book, add it to a shopping cart, list the items in the cart, remove a book from the cart, 
and check out. Use REST API for both the book and cart API (including the check-out action). 
Checking out will clear the cart. Logging in and out is not necessary. 
If the user exited the app but didn't clear their cart by checking out, the cart needs to be loaded when the application is restarted.

The solution should be created using the .NET 5 framework in the C# language. Ideally it uses React for the front end, but if that proves challenging then use a front-end framework of your choice.

BONUS 1: Create tests for the front and back end.

BONUS 2: Include prices in the book lists. Show the book prices in the cart and display total with tax.


Notes on this project:
This application demonstrates the .Net Core 5 Web API, a separate React front end project will be created soon!

Basically the shopping cart is saved for the client in the DB and contains products which are books so that the cart will not disappear if a cookie is deleted (as an example). An order is simply the cart items that are sent (not really sending) to the order service. 

Features:

Implementing Entity Framework Core in ASP.NET Core WebApi – Code-First Approach

DB Initializer for seeding data

Using SQLite DB (locally created by initializer) https://sqlitebrowser.org/

Trying out Model abstraction and table per model approach

Tried out the "many to many" relationship with books to authors

Setup:

Clone or get zip file

Open with Visual Studio and run the application, this will show the Swagger page

The DB can be removed from the root folder as the initializer can generate it

To reset the DB you can run the following from the project using the commandline

    dotnet ef migrations remove --force

    dotnet ef migrations add InitialCreate
    
    dotnet ef database update

TODO:

Add interfaces for the actions and set some actions to Not Implemented.

Add DTO's so we can also persist: created date, modified date, is deleted, etc.

Basic security and users

Try out Kestrel instead of IIS Express

Unit tests

Style recommendations

Client side (different project)
