# web-API-with-ASP.NET
A working local web API development with CRUD functionality using C#

//This is a simple project in ASP.NET using C#

//I Install the tool HTTP Read-Eval-Print-Loop for my testing 
// INSTALLATION FOR THE TESTING TOOL
// To install the tool httprepl

//in CLI 
> dotnet tool install -g Microsogt.dotnet-httprepl

//for the testing 
//in CLI 
> httprepl http://localhost:5000 

//to get or fetch data from your api
//you need to access the local directory of the API and input this to your terminal
//in CLI
> cd CoffeeHeaven 

//for fetching all the data in your api 
>get

//for fetching data of a particular Id of the object.
>get (number:example get 1)

//for adding another flavor or adding menu list in your store
>post -c "{"Name":"string", "sugarLevel" : "insert integer", "price":"insert double"}"
