using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitbox_Class_Libary
{
    /*-----------------------------------------------------------------
        class Door
     ------------------------------------------------------------------*/
    public class Door
    {
        private float Height;
        private string Material;
        private float Width;
        private bool DoorHandele;
        private int Nbr;
        public string Color;
        private List<Door> door_L = new List<Door>(); 
        // constructor
        public Door (float Height, string Material, float Width, bool DoorHandele, int Nbr)
        {
            this.Height = Height;
            this.Material = Material;
            this.Width = Width;
            this.DoorHandele = DoorHandele;
            this.Nbr = Nbr;
        }
        // property
        public string material { get{ return Material; } }
        public float height { get { return Height; } }
        public float width { get { return Width; } }
        public bool doorHandele { get { return DoorHandele; } }
        public int nbr { get { return Nbr; } }
        // method
        public void AddDoor(Door door)
        {
            door_L.Add(door);
        }
    }

    /*-----------------------------------------------------------------
        class Left_Door -Girl
     ------------------------------------------------------------------*/
    public class Left_Door : Door
        {
            public Left_Door (float Height, string Material, float Width, bool DoorHandele, int Nbr, string Color): base (Height, Material, Width, DoorHandele, Nbr)
                {
                    this.Color = Color;
                }
        }
    /*-----------------------------------------------------------------
    class Right_Door -Girl
     ------------------------------------------------------------------*/
    public class Right_Door : Door
        {
            public Right_Door(float Height, string Material, float Width, bool DoorHandele, int Nbr, string Color): base (Height, Material, Width, DoorHandele, Nbr)
                {
                     this.Color = Color;
                }
        }
    /*-----------------------------------------------------------------
    class Croos_beam
    -----------------------------------------------------------------*/
    public class Croos_beam
        {
        protected float lengh;
        protected int number;

        private List<Croos_beam> door_L = new List<Croos_beam>(); // création de la liste croos_beam
         
         public void AddCroos_beam(Croos_beam croos)// method
            {
                 door_L.Add(croos);
            }

        }
    /*-----------------------------------------------------------------
    class Frontal_crossbeam -Girl
    -----------------------------------------------------------------*/
    public class Frontal_crossbeam : Croos_beam
        {
             public Frontal_crossbeam (float lengh, int number)
             {
                 this.lengh = lengh;
                 this.number = number;
             }
         }
    /*-----------------------------------------------------------------
    class Rear_crossbeam -Girl
    -----------------------------------------------------------------*/
    public class Rear_crossbeam : Croos_beam
        {
        public Rear_crossbeam(float lengh, int number)
        {
            this.lengh = lengh;
            this.number = number;
        }
    }
    /*-----------------------------------------------------------------
    class Left_crossbeam -Girl
    -----------------------------------------------------------------*/
    public class Left_crossbeam : Croos_beam
        {
        public Left_crossbeam(float lengh, int number)
        {
            this.lengh = lengh;
            this.number = number;
        }
    }
    /*-----------------------------------------------------------------
    class Right_crossbeam -Girl
    -----------------------------------------------------------------*/
    public class Right_crossbeam : Croos_beam
        {
        public Right_crossbeam(float lengh, int number)
        {
            this.lengh = lengh;
            this.number = number;
        }
    }
    }

