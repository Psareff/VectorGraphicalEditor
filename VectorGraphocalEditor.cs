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
                Triangle tr1 = new Triangle((1, 1), (1000, 1), (500, 1200), Color.Green, Color.Green);

                VectorCanvas vc = new VectorCanvas();

                vc.AddFigureToPainting(cr1);
                Console.WriteLine("Width:" + vc.CanvasWidth + " Height:" + vc.CanvasHeight);
                vc.AddFigureToPainting(cr2);
                Console.WriteLine("Width:" + vc.CanvasWidth + " Height:" + vc.CanvasHeight);
                vc.AddFigureToPainting(tr1);
                Console.WriteLine("Width:" + vc.CanvasWidth + " Height:" + vc.CanvasHeight);
                vc.AddFigureToPainting(cr3);
                Console.WriteLine("Width:" + vc.CanvasWidth + " Height:" + vc.CanvasHeight);

                Console.WriteLine(vc.QtyOfFiguresOnCanvas().circleQty);
                Console.WriteLine(vc.QtyOfFiguresOnCanvas().trisQty);
                vc.DeleteByIndex(1);
                Console.WriteLine(vc.QtyOfFiguresOnCanvas().circleQty);
                Console.WriteLine(vc.QtyOfFiguresOnCanvas().trisQty);

                Figure tr4 = vc.Return1(2);

                double a = tr4.RadiusCalc();
                if (tr4 is Triangle)
                    ((Triangle)tr4).FirstVertex((2, 0));
                else a = ((Circle)tr4).RadiusCalc();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}