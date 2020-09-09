using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261025_mid
{
    class House
    {
        private int bedroom;
        private int bathroom;
        private float area;
        private Decoration decor;
        private Village villages;
        
        public House()
        {
        }

        public House(int bedroom, int bathroom,float area,Decoration decor,Village villages) 
        {
            this.bedroom = bedroom;
            this.bathroom = bathroom;
            this.area = area;
            this.decor = decor;
            this.villages = villages;
        }

        public int Bedroom { get => bedroom; set => bedroom = value; }
        public int Bathroom { get => bathroom; set => bathroom = value; }  
        public Decoration Decor  { get => decor; set => decor = value; }
        public Village Villages{ get => villages; set => villages = value; }

        public float getHouseCost(float area,int bedroom,int bathroom,Decoration decor)
        {
            float houseCost = 0;
            return houseCost = (this.area * this.Villages.Val) + (this.Bedroom * 100000) + (this.Bathroom * 100000) + this.decor.Cost;
        }
public override string ToString()
        {
            return "Location " + this.Villages.Name + " " +
                "House style" + this.Decor.Name + " " +
                "Bedroom " + this.Bedroom + " " +
                "Bathroom " + this.Bathroom + " " +
                "Area " + this.area + " " + " Square" + " " +
                "Decor " + this.Decor.Cost + " " +
                "Cost " + this.getHouseCost(this.area, this.bedroom, this.bathroom, this.decor) + " Million baht";
        }
    }
}
