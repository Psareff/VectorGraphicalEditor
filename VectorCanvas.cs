using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicalEditor
{
    public class VectorCanvas
    {
        double _CanvasHeight;
        double _CanvasWidth;
        Figure[] _FiguresArray;

        public VectorCanvas()
        {
            _CanvasHeight = 0;
            _CanvasWidth = 0;
            _FiguresArray = new Figure[0];
        }
        public VectorCanvas(Figure figure)
        {
            if (figure is null) throw new SystemException("Figure, pushed to constructor can't be null!");
            _FiguresArray = new Figure[1];
            _FiguresArray[0] = figure;
            _CanvasHeight = Convert.ToDouble(Math.Ceiling(figure is Circle ? ((Circle)figure).Radius * 2 : ((Triangle)figure).CircumscribedCircleRadiusCalculate() * 2));
            _CanvasWidth = _CanvasHeight;
        }
        public double CanvasHeight
        {
            get { return _CanvasHeight; }
            set { _CanvasHeight = value; }
        }
        public double CanvasWidth
        {
            get { return _CanvasWidth; }
            set { _CanvasWidth = value; }
        }
        public void AddFigureToPainting(Figure figure)
        {
            if (figure is null) throw new SystemException("Figure, pushed to adding op can't be null!");
            else
            {
                Array.Resize(ref _FiguresArray, _FiguresArray.Length + 1);
                _FiguresArray[_FiguresArray.Length - 1] = figure;
                foreach (Figure figureIterator in _FiguresArray)
                {

                    double heightBuffer = ((figureIterator is Circle ? ((Circle)figureIterator).Radius : ((Triangle)figureIterator).CircumscribedCircleRadiusCalculate()) +
                       Math.Abs((figureIterator is Circle ? ((Circle)figureIterator)._Center.Item2 : ((Triangle)figureIterator).CircumscribedCircleCenterCalculate().Item2)))*2;
                    double widthBuffer = ((figureIterator is Circle ? ((Circle)figureIterator).Radius : ((Triangle)figureIterator).CircumscribedCircleRadiusCalculate()) +
                       Math.Abs((figureIterator is Circle ? ((Circle)figureIterator)._Center.Item1 : ((Triangle)figureIterator).CircumscribedCircleCenterCalculate().Item1)))*2;

                    if (heightBuffer > _CanvasHeight)
                        _CanvasHeight = heightBuffer;
                    if (widthBuffer > _CanvasWidth)
                        _CanvasWidth = widthBuffer;
                }
                Console.WriteLine(_CanvasWidth);
                Console.WriteLine(_CanvasHeight);

            }
        }

    }
}
