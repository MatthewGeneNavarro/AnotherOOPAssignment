using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnothrOOPAssignment
{
    // child class of SalesPerson

    /*The RealEstateSalesperson class contains fields for total value sold in dollars and total commission earned (both of which are initialized to 0), and a commission rate field required by the class constructor.*/
    class RealEstateSalesPerson : SalesPerson
    {
        // fields
        private int _totalSold = 0;
        private int _totalCommission = 0;

        //properties
        public int TotalSold
        {
            get { return _totalSold; }
            set { _totalSold = value; }

        }
        public int TotalCommission
        {
            get { return _totalCommission; }
            set { _totalCommission = value; } // the commission is 25 percent of all sales.

        }
        //constructor
        public RealEstateSalesPerson(string firstN, string lastN,int totalCommission) :base(firstN, lastN)
        {// firstN, lastN are parameters from SalesPerson, and we can legally call them with the base keyword
            TotalCommission = totalCommission;
        }

        //Interfaces
        public int MakeSale(int sale)
        {
            
            return TotalSold += sale;

        }
        public void SalesSpeech()
        {
            Console.WriteLine("This house is perfect for you. Buy it!");
        }





    }
}
