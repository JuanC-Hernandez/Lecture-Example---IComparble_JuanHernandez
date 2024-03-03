using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___IComparble_JuanHernandez
{
    internal class Team_SortBudgeDsc : IComparer<Team>
    {
        public int Compare(Team x, Team y)
        {
            return x.Budget.CompareTo(y.Budget) * -1;
        }
    }
}
