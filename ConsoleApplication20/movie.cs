using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class movie
    {
        private string moviename;
        private string moviecategory;

        public string name
        {
            get
            {
                return moviename;
            }

            set
            {
                moviename = value;
            }
        }
        public string catagory
        {
            get
            {
                return moviecategory;
            }

            set
            {
                moviecategory = value;
            }
        }
        public movie(string mn, string cg)
        {
            moviename = mn;
            moviecategory = cg;
        }


    }

}
