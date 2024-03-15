using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp282_Coursework2
{
    class Country
    {
        private string _name;
        private long _population;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public long Population
        {
            get { return _population; }
            set { _population = value; }
        }

        public Country (string Name, long Population)
        {
            this.Name = Name;
            this.Population = Population;
        }

        public override string ToString()
        {
            return Name + " " + Population;
        }
    }
}
