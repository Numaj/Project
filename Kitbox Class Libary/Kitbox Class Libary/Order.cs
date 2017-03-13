using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitbox_Class_Libary
{
    class Order
    {
        //Fields
        private double totalprice;
        private string orderID;
        private List<CabinetKit> list_of_cabinetkits;

        //Properties/Accessors
        public List<CabinetKit> List_of_cabinetkits
        {
            get { return list_of_cabinetkits; }
            set { list_of_cabinetkits = value; }
        }
        public double Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
        public string OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        //Constructor
        public Order()
        {

        }

        //Methods
        public float CalculatePrice(List<CabinetKit> list_of_cabinetkits)
        {
            return 0;
        }
    }
}
