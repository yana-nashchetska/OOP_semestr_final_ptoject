using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_FINAL_PROJECT
{
    public class JewelryShop
    {
        private string _address;
        private int _amount;
        public List<Jewelry> Jewelries { get; set; } = new List<Jewelry>();


        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}