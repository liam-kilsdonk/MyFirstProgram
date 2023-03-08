using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Xml.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        /* C# - Periode 7 - Week 1 - Opstart, Part 1 & 2 Door Liam */

        Console.WriteLine("EXERCISE cases: 1 - 1-10: Name Profession, 2 - 1-15: Asking Multiple Inputs, 3 - 1-23: Tiny Calculator,\r\n" +
            "4 - 1-33: Echo, 5 - 1-40: Amount and Sum, 6 - 2-4: Comparison, 7 - 2-8: Numbers and Calculations ");
        Console.WriteLine("Kies je case nummer: ");
       
        int userInput = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(userInput);

        switch (userInput)
        {
            case 1:
                nameProfession();
                break;
            case 2:
                askingMultipleInputs();
                break;
            case 3:
                tinyCalculator();
                break;
            case 4:
                echo();
                break;
            case 5:
                amountAndSum();
                break;
            case 6:
                comparison();
                break;
            case 7:
                numbersAndCalculations();
                break;
        }



        static void nameProfession()
        {
            Console.WriteLine("I will tell a story, but I need some information.\r\nGive a name for main character: ");
            String naam = Console.ReadLine();
            Console.WriteLine(naam);
            Console.WriteLine("Give the character a profession: ");
            String werk = Console.ReadLine();
            Console.WriteLine(werk);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Here is the story:\r\nOnce upon a time there was a " + werk + " called " + naam + "\r\nOn her way to work, " + naam + " often pondered what being " + werk + " meant to them.\r\nWhen you work as a " + werk + " you meet interesting people.\r\n" + naam + " enjoys their work as " + werk + ", The end.");
        }

        static void askingMultipleInputs()
        {
            Console.WriteLine("hallo type hier een woord: ");
            String woord = Console.ReadLine();
            Console.WriteLine("type hier een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("type hier een decimaal: ");
            double decimaal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("type hier true of false: ");
            String booly = Console.ReadLine();
            bool valid = true;

            if (booly == "true")
            {
                valid = true;
            }
            else if (booly == "false")
            {
                valid = false;
            }

            Console.WriteLine("het woord: " + woord);
            Console.WriteLine("The magic number: "+ getal);
            Console.WriteLine("Het decimaal: " + decimaal);
            Console.WriteLine("het booly waarde : " + booly);
        }

        static void tinyCalculator()
        {
            Console.WriteLine("welkom bij rekenen: \r\n" +
                "Voer 2 getallen bij elkaar op");

            Console.WriteLine("eerste getal: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tweede getal: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            int uitkomst = getal1+ getal2;

            Console.WriteLine("hier is je uitkomst: "+uitkomst);
        }

        static void echo()
        {
            Console.WriteLine("je gaat 2 woorden typen als \r\n" +
                "ze gelijk zijn woord Echo geprint anders Nope");

            Console.WriteLine("het eerste woord: ");
            String woord1 = Console.ReadLine();
            Console.WriteLine("tweede woord : ");
            String woord2 = Console.ReadLine();

            if (woord1 == woord2)
            {
                Console.WriteLine("Echo");
            }
            else
            {
                Console.WriteLine("Nope");
            }
        }

        static void amountAndSum() /* ik begreep niet wat de bedoeling hier was */
        {
            int amount = 0;
            int sumA = 0;
            int timer = 0;

            Console.WriteLine("Voer getallen in, je mag dit maar 3 keer doen");
            while (timer < 3)
            {
                Console.WriteLine("Voer een getal in: ");
                amount = Convert.ToInt32(Console.ReadLine());
                timer++;
                sumA = amount + amount;
            }
            Console.WriteLine("amount: "+amount);
            Console.WriteLine("sum: "+sumA);

        }

        static void comparison()
        {
            Console.WriteLine("Voer 2 getallen in: deze zullen vergeleken worden \r\n" +
                "als een groter dan de andere is woord groter geprint ander lager of gelijk");

            Console.WriteLine("Voer eerste getal in: ");
            int com1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer nu het tweede getal in: ");
            int com2 = Convert.ToInt32(Console.ReadLine());
            if (com1 == com2)
            {
                Console.WriteLine("Bijde getalen zijn gelijk");
            }
            else if (com1 > com2)
            {
                Console.WriteLine(com1 +" is groter dan "+ com2);
            }
            else
            {
                Console.WriteLine(com2 + " is groter dan " + com1);
            }
        }
        static void numbersAndCalculations()
        {
            Console.WriteLine("Give numbers: ");
        }
    }
}