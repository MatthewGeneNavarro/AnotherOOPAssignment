using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnothrOOPAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Instance
            RealEstateSalesPerson agent = new RealEstateSalesPerson("Matthew", "Navarro", 2);

            //Console.WriteLine(agent.TotalCommission);
            agent.SalesSpeech();
            agent.MakeSale(100000);

            Console.WriteLine("Agent {0} {1} sold {2} dollars in property and has {3} percent in commission and made {4}", agent.FirstName, agent.LastName, agent.TotalSold,agent.TotalCommission, (agent.TotalSold / agent.TotalCommission));
            agent.SalesSpeech();
            agent.MakeSale(50000);
            Console.WriteLine("Agent {0} {1} sold another house. His total sales are now {2} and has made {3} off his commission.", agent.FirstName, agent.LastName, agent.TotalSold, (agent.TotalSold / agent.TotalCommission));


            // Object Instance
            GirlScout scout = new GirlScout("Kaitlin", "Navarro");
            // Implemented Interfaces being used by their objects.
            scout.SalesSpeech();
            scout.MakeSale(10);
            Console.WriteLine("Girl Scout {0} {1} sold {2} boxes of cookies.", scout.FirstName, scout.LastName, scout.BoxesSold);
            scout.SalesSpeech();
            scout.MakeSale(20);
            Console.WriteLine("Girl Scout {0} {1} sold {2} boxes of cookies.", scout.FirstName, scout.LastName, scout.BoxesSold);

            Console.ReadKey();
            

           
        }
    }
}
