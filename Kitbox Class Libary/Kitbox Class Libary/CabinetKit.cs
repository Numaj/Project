using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitbox_Class_Libary
{
    public class CabinetKit
    {
        //Fields
        private int nbr_racks;
        private double width;
        private double depth;
        private double identical_rack_height;
        private List<Racks> list_of_racks;

        //Properties/Accessors
        public List<Racks> List_of_racks
        {
            get { return list_of_racks; }
            set { list_of_racks = value; }
        }
        public int Nbr_racks
        {
            get { return nbr_racks; }
            set { nbr_racks = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Depth
        {
            get { return depth; }
            set { depth = value; }
        }
        public double Identical_rack_height
        {
            get { return identical_rack_height; }
            set { identical_rack_height = value; }
        }

        //Constructor
        public CabinetKit()
        {

        }

        //Methods

        //
        public void AddRack(Rack rack)
        {

        }

        //
        public void SelectDepth(double depth)
        {
            Depth = depth;
        }

        //
        public void SelectWidth(double width)
        {
            Width = width;
        }

        //
        public void Select_Identical_RackHeight(double height)
        {
            Identical_rack_height = height;
        }

        //
        public void Select_SteelBars_colour(string colour )
        {

        }

        //
        public void Select_DoorAdd(bool doorChoice)
        {

        }

        //
        public void Select_DoorHandleAdd(bool doorHandleChoice)
        {

        }

        //
        public void Select_DoorColour(bool doorHandleChoice)
        {

        }

        //
        public void Select_DoorMaterial(string doorMaterial )
        {

        }

        //
        public void Select_PanelsColours(string rearPanel, string topPanel, string bottomPanel, string leftPanel, string RightPanel)
        {

        }

        //
        public void Select_CrossbeamsColours(string rearCrossbeam, string frontalCrossbeam, string LeftCrossbeam, string rightCrossbeam)
        {

        }
    }
}
