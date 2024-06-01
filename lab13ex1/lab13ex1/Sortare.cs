using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13ex1
{
   
        public class SortByName : IComparer<global::Persoana>
        {
            public int Compare(global::Persoana p1, global::Persoana p2)
            {
                return string.Compare(p1.Nume, p2.Nume);
            }
        }
        public class SortByAge : IComparer<global::Persoana>
        {
            public int Compare(global::Persoana p1, global::Persoana p2)
            {
                if (p1.Varsta < p2.Varsta)
                {

                    return -1;
                }
                if (p1.Varsta > p2.Varsta) { return 1; }
                return 0;
            }
        }
    }


