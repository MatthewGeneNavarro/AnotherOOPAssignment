using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnothrOOPAssignment
{
    abstract class SalesPerson
    {

        // fields
        private string _fName;
        private string _lName;
        // properties
        public string FirstName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        public string LastName
        {
            get { return _lName; }
            set { _lName = value; }
        }
        //constructor
        public SalesPerson(string firstN, string lastN)
        {
            FirstName = firstN;
            LastName = lastN;
        }


        //methods
        public void Name(string firstN, string lastN)
        {
            Console.WriteLine("{0} {1} is a Sales person", FirstName, LastName);

        }

        //Interface
        public interface ISellable
        {
            string SalesSpeech();
            int MakeSale();
        }

    }
}
