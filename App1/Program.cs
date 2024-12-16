// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string FirstName = "Bader";
string LastName = "AlQallaf";

int num1, num2, sum;
num1 = 5;
num2 = 7;
sum = num1 + num2;

string N1, N2, N3;
N1 = "3";
N2 = "4";
N3 = "5";

string Total = (Convert.ToInt32(N1) + Convert.ToInt32(N2) + Convert.ToInt32(N3)).ToString();
     
Console.WriteLine("Mr." + FirstName + " " + LastName + " " + "Your number is: " + sum);
Console.WriteLine("Total is : " + Total);

Console.WriteLine("--------------------------------");

Console.WriteLine("Enter Your Full Name: ");
string FulllName = Console.ReadLine();

Console.WriteLine("Enter Your City: ");
string City = Console.ReadLine();

Console.WriteLine("Welcome " + FulllName + " My city is : " + City);

Console.WriteLine("--------------------------------");

Console.WriteLine("Enter value one: ");
string value1 = Console.ReadLine();

Console.WriteLine("Enter value two: ");
string value2 = Console.ReadLine();

string values = (Convert.ToInt32(value1) + Convert.ToInt32(value2)).ToString();

Console.WriteLine("total : " + values);

Console.WriteLine("--------------------------------");

