using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polimorphism.Models
{
    internal class Rectangular : Figure
    {
        private double _width;
        private double _length;

        public double Width 
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            } 
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }

        public Rectangular(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override void CalcArea() 
        {
            Console.WriteLine("Duzbucaqlinin sahesi : " + Width * Length);
        }
        
    }
}
