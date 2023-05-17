using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FINAL_PROJECT
{
    public class Jewerly
    {
        private string name;
        private string metal;
        private double weight;
        private double price;

        public string Name
        {
             get { return name; }
             set { name = value; } 
        }
        public string Metal
        {
            get { return metal; }
            set { metal = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}
