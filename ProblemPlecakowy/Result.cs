using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProblemPlecakowy;

namespace ProblemPlecakowy
{
    internal class Result
    {
        private List<int> itemsID;

        public List<int> ItemsID
        {
            get { return itemsID; } 
        }

        private int totalW;
        private int totalV;
        public int TotalW { get; set; }
        public int TotalV { get; set; }

        public Result(List<int> itemsID, int totalW, int totalV)
        {
            this.totalV = totalV;
            this.totalW = totalW;
            this.itemsID = itemsID;
        }

        public override string ToString()
        {
            string output = "items: ";
            foreach(var id in this.itemsID) {
                output += id + " ";
            }
            output += Environment.NewLine + $"total value: {this.totalV}";
            output += Environment.NewLine + $"total weight: {this.totalW}";

            return output;
        }
    }
}
