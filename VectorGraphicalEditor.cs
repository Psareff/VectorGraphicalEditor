using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicalEditor
{
    class VectorGraphicalEditor
    {
        public static void Main()
        {
            try
            {
                Circle cr1 = new Circle((-10, -5), 11, Color.Red, Color.Blue);
                Circle cr2 = new Circle((-12, -24), 100, Color.Red, Color.Blue);
                Circle cr3 = new Circle((1, -1), 2, Color.Red, Color.Blue);
                Triangle tr1 = new Triangle((1, 1), (500, 1), (250, 500), Color.Green, Color.Green);
                Circle[] crarray =  { cr1, cr2, cr3 };
                VectorCanvas vc = new VectorCanvas();
                VectorCanvas vc1 = new VectorCanvas(crarray);
                Console.WriteLine("Width:" + vc1.CanvasWidth + " Height:" + vc1.CanvasHeight);
                vc1.AddFigureToPainting(tr1);
                Console.WriteLine("Width:" + vc1.CanvasWidth + " Height:" + vc1.CanvasHeight);

                tr1.SecondVertex = (1000, 1000);
                /*
                double a = tr4.RadiusCalc();
                if (tr4 is Triangle)
                    ((Triangle)tr4).ThirdVertex = (1000,1);
                else a = ((Circle)tr4).RadiusCalc();
                */
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}