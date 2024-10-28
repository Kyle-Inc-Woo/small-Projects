namespace BackAccountSystem;

class Program
{
    static void Main(string[] args)
    {
        double balance = 100;
        string accountNumber = "1002956496024";
        string owner = "Inchang Woo";
        
        BankAccount bankaccount = new BankAccount(balance, accountNumber, owner);

        while (true)
        {
            Console.WriteLine
            (
                "Welcome to Simple Bank Account System!\n"+
                "1 -- Deposit\n"+
                "2 -- Withdraw\n"+
                "3 -- Display Balance\n"+
                "4 -- Show Account Information\n"+
                "5 -- Exit\n"+
                "Please select an option: "
            );

            if (!int.TryParse(Console.ReadLine(), out int option) || option <1 || option >6) 
            {
                Console.WriteLine("invalid option, Please enter again");
                    continue; 
                
            }

            if (option == 1)
            {
                Console.WriteLine("Please enter amount of deposit : ");
                if (double.TryParse(Console.ReadLine(), out double depositAmount))
                {
                    Console.WriteLine(bankaccount.Deposit(depositAmount));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                
            }

            if (option == 2)
            {
                Console.WriteLine("Please enter amount of withdraw: ");
                if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                {
                    Console.WriteLine(bankaccount.Withdraw(withdrawAmount));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (option == 3)
            {
                bankaccount.DisplayBalance();
            }

            if (option == 4)
            {
                Console.WriteLine(bankaccount.ToString());
            }

            if (option == 5)
            {
                Console.WriteLine("Do you want to exit program? (y/n)");
                string response = Console.ReadLine();

                if (response.ToLower() != "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        Console.ReadLine();
        
    }
}