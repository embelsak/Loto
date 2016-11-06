using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO
{
    class Loto
    {
        public List<int> uplaceniBrojevi { get; set; }
        public List<int> dobitniBrojevi { get; set; }

        public Loto()
        {
            uplaceniBrojevi = new List<int>();
            dobitniBrojevi = new List<int>();
        }

        public bool unesiUplaceneBrojeve(List<string> korisnickeVrijednosti)
        {
            bool ispravni = false;
            uplaceniBrojevi.Clear();
            foreach(string v in korisnickeVrijednosti)
            {
                int broj = 0;
                if(int.TryParse(v,out broj)==true)
                {
                    if(broj>= 1 && broj <= 39)
                    {
                        uplaceniBrojevi.Add(broj);
                    }
                }
            }
            if(uplaceniBrojevi.Count == 7)
            {
                ispravni = true;
            }
            return ispravni;
        }

        public void generirajDobitnuKombinaciju()
        {
            dobitniBrojevi.Clear();
            Random random = new Random();
            while(dobitniBrojevi.Count < 7)
            {
                int broj = random.Next(1, 39);
                if (dobitniBrojevi.Contains(broj) == false)
                {
                    dobitniBrojevi.Add(broj);
                }
            }
        }

        public int izracunajBrojPogodaka()
        {
            int brojPogodaka = 0;
            foreach(int broj in uplaceniBrojevi)
            {
                if (dobitniBrojevi.Contains(broj) == true)
                {
                    brojPogodaka++;
                }
            }
            return brojPogodaka++;
        }
    }
}
