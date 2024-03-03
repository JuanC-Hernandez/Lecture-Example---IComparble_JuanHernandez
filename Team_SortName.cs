using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___IComparble_JuanHernandez
{
    internal class Team_SortName : IComparer<Team>
    {
        public enum SortingOrder { Ascending, Descending };
        public SortingOrder Sorting;


        public Team_SortName()
        {
            Sorting = SortingOrder.Descending;
        }
        public Team_SortName(SortingOrder sorting)
        {
            Sorting = sorting;
        }

        public int Compare(Team x, Team y)
        {
            if (Sorting == SortingOrder.Descending)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return x.Name.CompareTo(y.Name) * -1;
            }

        }
    }
}
