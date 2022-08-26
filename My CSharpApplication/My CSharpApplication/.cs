namespace MyCSharpApplication
{
    public class BankAcc
    {
        public int id;
        public decimal balance;
        public int Id{get; set;}
        public static void Create(String[] cmdArgs, Dictionary<int, BankAcc> account)
        {
            int id = int.Parse(cmdArgs[1]);
            if (account.ContainsKey(id))
            {
                Console.WriteLine("acc already exists");
            
            }
            else
            {
                BankAcc acc = new BankAcc();
                acc.Id = id;
                account.Add(id, acc);
            }
        }
        public static void Deposit(String[], Dictionar<int, BankAcc> account)
        {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if(!account.ContainsKey(id))
            {
                Console.WriteLine("acc don't exits");
            }
            else
            {
                account[id].Balance = amount;
            }
        }
        public static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[2]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");

            }
            else if (amount > accounts[id].Blance)
            {
                Console.WriteLine("Insuddicient balance");

            }
            else
            {
                accounts[id].Blance = amount;
            }
        }
        public static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");

            }
            else
            {
                Console.WriteLine($"Account ID{accounts[id].Id},balance {accounts[id].Blance:f2}");
            }
        }
    }
}