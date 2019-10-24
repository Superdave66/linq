using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtask
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqThings linq = new LinqThings();

            linq.MakeWords();
            linq.RemoveDuplicates();
            linq.GetAverageDropLowest();

        }
    }
}
