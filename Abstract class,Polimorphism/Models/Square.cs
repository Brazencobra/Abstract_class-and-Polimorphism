using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polimorphism.Models
{
    internal class Square : Figure
    {
        private double _side;

        public double Side 
        {
            get
            {
                return _side;
            }
            set
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
        }

        public Square(double side)
        {
            Side = side;    
        }

        public override void CalcArea()
        {
            Console.WriteLine("Kvadratin sahesi : " + Side * Side);
        }
        
    }
}
