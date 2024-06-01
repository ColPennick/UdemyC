using System.Xml.Serialization;

namespace BankAccount
{
    internal class BankAccount
    {
        // Eigenschaften
        public string Number { get; private set; }
        public string Owner { get; private set; }
        public float Balance { get; private set; }

        // Konstruktor
        public BankAccount(string number, string owner, float initialBalance)
        {
            Number = number;
            Owner = owner;
            Balance = initialBalance;
        }

        // Methode für Einzahlung
        public void makeDeposit(float amount)
        {
            Balance += amount;
        }

        // Methode für Auszahlung
        public void makeWithdrawal(float amount)
        {
            if(amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Transkation abgeschlossen.");
                PrintBalance();
            }
            else
            {
                Console.WriteLine($"Saldo von {Balance} unzureichend für Ihre Anfrage.\n");
            }

        }

        // Methode für Ausgabe des Kontostands
        public void PrintBalance()
        {
            Console.WriteLine($"Kontostand von {Owner}: {Balance}.\n");
        }

        public void PrintBankBanner()
        {
            Console.WriteLine("" +
                "*** NoTrust Bank Inc ***\n" +
                "***   it wasn't us   ***");
        }
    }
}