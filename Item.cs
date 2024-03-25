using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Item
    {
        private int id, waga, wartosc;
        public int Id { get; set; }
        public int Waga {  get; set; }
        public int Wartosc { get; set; }

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
