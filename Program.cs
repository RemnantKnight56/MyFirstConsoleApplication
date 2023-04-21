// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name = "Jeremy Cole";
string location = "Idaho";

Console.WriteLine("My name is " + name + ", I am from " + location + "\n");

DateTime date = DateTime.Today;

Console.WriteLine("Date: " + date.ToString("d"));

DateTime christmasDate = new DateTime(date.Year, 12, 25);
var numberOfDays = (christmasDate - date).TotalDays;

Console.WriteLine("Days Until Christmas: " + numberOfDays);

double width, height, woodLength, glassArea;
string widthString, heightString;
Console.WriteLine("Enter width: ");
widthString = Console.ReadLine();
width = double.Parse(widthString);
Console.WriteLine("Enter height: ");
heightString = Console.ReadLine();
height = double.Parse(heightString);
woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);
Console.WriteLine("The length of the wood is " +
woodLength + " feet");
Console.WriteLine("The area of the glass is " +
glassArea + " square metres");

Console.ReadKey();