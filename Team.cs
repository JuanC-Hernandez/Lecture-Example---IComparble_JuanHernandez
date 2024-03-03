using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___IComparble_JuanHernandez
{
    public class Team : IComparable<Team>
    {
        string _name;
        string _city;
        double _budget;

        public Team(string name, string city)
        {
            Random rand = new Random();
            _name = name;
            _city = city;
            _budget = rand.Next(1000000, 100000000);
        }

        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public double Budget { get => _budget; set => _budget = value; }

        public int CompareTo(Team other)
        {

            return _city.CompareTo(other.City);

        }

        public override string? ToString()
        {
            return $"{_city} {_name} - {_budget.ToString("c")}";
        }
    }
}
