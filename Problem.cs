using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Problem {
        private int N;
        private Item[] items;
        
        public Problem(int n, int seed) {
            this.N = n;
            this.items = new Item[this.N];
            Random random = new Random(seed);

            for (int i = 0; i < this.N; i++)
            {
                this.items[i] = new Item(i, random.Next(1, 10), random.Next(1, 10));
            }

        }


        struct ItemCoeff { 
            public int id;
            public float coeff;
            public ItemCoeff(int id, float coeff) { this.id = id; this.coeff = coeff; }
        }
        public void Solve(int cap) {
            List<ItemCoeff> coeffs = [];
            foreach(var item in this.items)
            {
               coeffs.Add(new ItemCoeff(item.Id, item.Wartosc/item.Waga));
            }
            coeffs.Sort();
        }

            

        public override string ToString()
        {
            string output = "";
            foreach(var item in this.items)
            {
                output += item.ToString() + Environment.NewLine;
            }
            return output;
        }
    }
}
