
namespace mycalculator
{
    class Tipcalculator
    {
        public string? Name { get; set; } 
        public string? password { get; set; }
        public void GetData()
        {
            Print("Enter user Name:");
            Name =  Console.ReadLine();
            Print("Enter password");
            password = Console.ReadLine();
            if (Name.ToLower() == "admin" && password == "1234")
            {
                Print("Login successful!");
                Print("Enter total bill amount in '$':");
                double billAmount = Convert.ToDouble(Console.ReadLine());
                Print("Enter Tip amount:'%'");
                double tipPercentage = Convert.ToDouble(Console.ReadLine());
                double tipAmount = tipPercentage / 100 * billAmount;
                Print($"tip amount is:${tipAmount}");
                Print($"Total amount to pay:${tipAmount + billAmount}");
            }
            else
            {
                Print("Enter user Name: user");
                Print("Enter password: wrongpass");
                Print("Invalid Username or Password Access Denied...");
            }
        }
        public void Print(string message) => Console.WriteLine(message);
    }
}