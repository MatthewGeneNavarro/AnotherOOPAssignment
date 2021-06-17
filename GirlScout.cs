using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnothrOOPAssignment
{
    // child class of SalesPerson
    class GirlScout : SalesPerson

    /*
    The GirlScout class includes a field to hold the number of boxes of cookies sold, which is initialized to 0. Include properties for every field.*/
    {
        private int _boxesSold = 0;

        public int BoxesSold
        {
            get { return _boxesSold; }
            set
            {
                _boxesSold = value;
            }
        }
        // using base keyword to include SalesPerson parameters in the GirlScout contstructor
        public GirlScout(string firstN, string lastN) : base(firstN, lastN) { }

        //Interfaces
        public void SalesSpeech()
        {
            Console.WriteLine("Would you like to buy some Thin Mints?");

        }
        public int MakeSale(int sale)
        {
            return BoxesSold += sale;

        }





    }
}
