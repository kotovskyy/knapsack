using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Knapsack_test")]
namespace ProblemPlecakowy
{
    internal class Item
    {
        private int id, waga, wartosc;
        public int Id {
            get { return id; } 
            set { id = value; }
        }
        public int Waga
        {
            get { return waga; }
            set { waga = value; }
        }
        public int Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }

        public Item(int id, int waga, int wartosc)
        {
            this.id = id;
            this.waga = waga;
            this.wartosc = wartosc;
        }

        public override string ToString()
        {
            return $"No.: {this.id} | v: {this.wartosc} | w: {this.waga}";
        }
    }
}
