using MessengerLibrary;


Console.WriteLine("this is the client who is using MessangerLibrary");

// creating an object of Messanger class
Messanger messanger = new Messanger();

// caliing the instance method of the class using reference variable and storing the reyurned value in message
string message = messanger.GetMessage("Sayeedul");
Console.WriteLine(message);