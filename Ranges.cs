using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagrutListLab
{
    public class Ranges
    {
        private int high;
        private int low;
        public Ranges(int low, int high)
        {
            this.high = high;
            this.low = low;
        }
        public int GetHigh()
        {
            return high;
        }
        public int GetLow()
        {
            return low;
        }
        public override string ToString()
        {
            string str="["+this.low+","+this.high+"]";
            return str;
        }
    }
}
