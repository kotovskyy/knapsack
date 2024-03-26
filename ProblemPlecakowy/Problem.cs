using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProblemPlecakowy;

[assembly: InternalsVisibleTo("UnitTests")]
namespace ProblemPlecakowy
{
    internal class Problem {
        private int N;
        private Item[] items;

        public Item[] Items
        {
            get { return items; }
            set
            {
                this.items = new Item[this.N];
                for (int i = 0; i < this.N; i++)
                {
                    this.items[i] = value[i];
                }
            }
        }

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

        public Item FindItemById(int id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }

        public Result Solve(int cap) {
            ItemCoeff[] itemsCoeffs = new ItemCoeff[this.N];
            for (int i = 0; i < this.N; ++i) 
            {
                itemsCoeffs[i].id = this.items[i].Id;
                itemsCoeffs[i].coeff = (float)this.items[i].Wartosc / this.items[i].Waga;
            }
   
            Array.Sort(itemsCoeffs, (x, y) => y.coeff.CompareTo(x.coeff));

            List<int> knapsack = new List<int>();
            int occupied = 0;
            int totalWartosc = 0;

            for (int i = 0; i < this.N; i++)
            {
                Console.WriteLine($"id: {itemsCoeffs[i].id}, {itemsCoeffs[i].coeff}");
            }

            foreach (var itemCoeff in itemsCoeffs)
            {
                Item item = FindItemById(itemCoeff.id);
                if (occupied == cap) { break; }
                if (occupied + item.Waga > cap) { continue; }
                occupied += item.Waga;
                totalWartosc += item.Wartosc;
                knapsack.Add(item.Id);

                Console.WriteLine($"{ itemCoeff.id} , {occupied}, {totalWartosc}, {itemCoeff.coeff}");
            }

            Result result = new Result(knapsack, occupied, totalWartosc);

            return result;
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
