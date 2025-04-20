using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagrutListLab
{
    public class Group
    {
        private string[] namesArr;
        private int kamut;
        public Group(string[] namesArr,int kamut)
        {
            this.namesArr = namesArr;
            this.kamut = kamut;
        }
        public int GetKamut()
        {
            return kamut;
        }
        public string[] GetNamesArr()
        {
            return namesArr;
        }
        public bool IsIncluded(string name)
        {
            for (int i = 0; i < this.kamut; i++)
            {
                if (name == this.namesArr[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
