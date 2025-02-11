using System;
public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: ${Balance}");
    }
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Account Type: General Bank Account");
    }
}

public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }
    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Savings Account");
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }
}
public class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }
    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Checking Account");
        Console.WriteLine($"Withdrawal Limit: ${WithdrawalLimit}");
    }
}

public class FixedDepositAccount : BankAccount
{
    public int TermLength { get; set; }
    public FixedDepositAccount(string accountNumber, double balance, int termLength)
        : base(accountNumber, balance)
    {
        TermLength = termLength;
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine($"Term Length: {TermLength} months");
    }
}
public class Program
{
    public static void Main()
    {
        SavingsAccount savings = new SavingsAccount("SA12345", 5000.00, 3.5);
        CheckingAccount checking = new CheckingAccount("CA98765", 1500.00, 2000.00);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount("FD112233", 10000.00, 12);
        Console.WriteLine("Savings Account Details:");
        savings.DisplayAccountInfo();
        savings.DisplayAccountType();
        Console.WriteLine("\nChecking Account Details:");
        checking.DisplayAccountInfo();
        checking.DisplayAccountType();
        Console.WriteLine("\nFixed Deposit Account Details:");
        fixedDeposit.DisplayAccountInfo();
        fixedDeposit.DisplayAccountType();
    }
}
