using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.PrintBankBanner();
            while (true)
            {
                // Menü
                Console.WriteLine("Bitte wählen Sie eine Aktion aus:");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1) Kontostand anzeigen");
                Console.WriteLine("2) Einzahlung");
                Console.WriteLine("3) Auszahlung");
                Console.WriteLine("4) Beenden");
                Console.WriteLine("5) Neues Konto anlegen");

                // Eingabe
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    account.PrintBalance();
                }
                else if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie einzahlen möchten:");
                    float amount = float.Parse(Console.ReadLine());
                    account.makeDeposit(amount);
                    Console.Clear();
                    Console.WriteLine($"{amount} wurden Ihrem Konto gutgeschrieben.\n");
                }
                else if (input == "3")
                {

                    Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie abheben möchten:");
                    float amount = float.Parse(Console.ReadLine());
                    Console.Clear();    
                    account.makeWithdrawal(amount);
                }
                else if (input == "4")
                {
                    break;
                }
                else if (input == "5")
                {
                    Console.Clear();
                    account.CreateAccount();
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
                    
                
            }
        }
    }
}
