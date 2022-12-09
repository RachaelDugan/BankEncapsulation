namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccountClass account = new BankAccountClass();

            Console.WriteLine($"Current balance: ${account.GetBalance()}");
            Console.WriteLine("Enter your deposit amount: ");
            string deposit = Console.ReadLine();
            account.Deposit(double.Parse(deposit));
            Console.WriteLine($"Amount added to your account: {deposit, 0:c}");
            Console.WriteLine($"New balance: {account.GetBalance()}");
            
            Console.WriteLine("Enter your deposit amount: ");
            deposit = Console.ReadLine();
            account.Deposit(double.Parse(deposit));
            Console.WriteLine($"Amount added to your account: {deposit,0:c}");
            Console.WriteLine($"New balance: {account.GetBalance()}");

        }
    }
}