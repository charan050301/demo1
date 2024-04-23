namespace BankingApplication;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter intital amount");
        double initialAmount=Convert.ToDouble(Console.ReadLine());
        Account myAccount = new Account(accountNumber: 12345, customerName: "John Doe", initialAmount);
 
            myAccount.UnderBalance += (balance) => Console.WriteLine($"Balance is below 100. Current balance: {balance}");
            myAccount.BalanceZero += () => Console.WriteLine("Balance reached zero!");
 
        Console.WriteLine("your initial balance amount");
            myAccount.Deposit(100);
            myAccount.Withdraw(200);
            //myAccount.Withdraw(90);
            Console.WriteLine(Hi ra Mama);
    }
}
