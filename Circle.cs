using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicalEditor
{
    internal class Circle : Figure
    {
        internal (double, double) _Center;
        internal double _Radius;
        (double, double) Center
        {
            get { return _Center; }
            set { _Center = value; }
        }

        internal double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }

        public Circle() : base(Color.White, Color.White)
        {   
            _Radius = 1;
            _Center = (0, 0);
        }

        public Circle((double, double) Center, double Radius, Color FillColor, Color ContourColor) : base (FillColor, ContourColor)
        {
            _Center = Center;
            _Radius = Radius;
        }

        public override double PerimeterCalculate()
        {
            return 2*Math.PI*_Radius;
        }
        public override double SquareCalculate()
        {
            return Math.PI*Math.Pow(_Radius, 2);
        }
        public override void ShiftOxOy((double, double) Shift)
        {
            _Center.Item1 += Shift.Item1;
            _Center.Item2 += Shift.Item2;
        }
    }
}
