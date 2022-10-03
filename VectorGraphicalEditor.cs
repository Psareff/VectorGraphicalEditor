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
                //Triangle tr1 = new Triangle((1, 0), (2, 2), (3, 0), Color.Red, Color.Blue);
                Circle cr1 = new Circle((-10, -5), 11, Color.Red, Color.Blue);
                Circle cr2 = new Circle((-12, -24), 100, Color.Red, Color.Blue);
                Circle cr3 = new Circle((1, -1), 2, Color.Red, Color.Blue);
                Triangle tr1 = new Triangle((1, 1), (1000, 1), (500, 1200), Color.Green, Color.Green);
                //Circle cr4 = new Circle((100, -100), 2000, Color.Red, Color.Blue);


                VectorCanvas vc = new VectorCanvas();

                //Console.WriteLine(vc.CanvasWidth);
                //Console.WriteLine(vc.CanvasHeight);
                vc.AddFigureToPainting(cr1);
                Console.WriteLine("Width:" + vc.CanvasWidth + " Height:" + vc.CanvasHeight);
                vc.AddFigureToPainting(cr2);
                Console.WriteLine("Width:" + vc.CanvasWidth + " Height:" + vc.CanvasHeight);
                vc.AddFigureToPainting(cr3);
                Console.WriteLine("Width:" + vc.CanvasWidth + " Height:" + vc.CanvasHeight);
                vc.AddFigureToPainting(tr1);
                Console.WriteLine("Width:" + vc.CanvasWidth + " Height:" + vc.CanvasHeight);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
