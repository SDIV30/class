namespace Geom
{
    public class Square
    {
        /*
         * Не понял как сделать определение фигуры поэтому предопределил Круг или Треугольник
         * В дальнейшем можно добавить больше фигур методами
         */

        //расчёт площади круга
        public static double Circle(float Rad)
        {
            if (Rad > 0)
            {
                double s = Math.Pow(Rad, 2) * Math.PI;
                return s;
            }
            else 
            {
                return 0;
            }
        }
        //расчёт площади треугольника
        public static double Triangle(float side1,float side2,float side3)
        {
            if ((side1 + side2 > side3) || (side1 + side3 > side2) || (side3 + side2 > side1))
            {
                //полупериметр
                double p = ((side1 + side2 + side3) / 2);
                //формула герона
                double s = (Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)));
                return s;
            }
            else 
            {  
                return 0;
            }
        }

    }
}