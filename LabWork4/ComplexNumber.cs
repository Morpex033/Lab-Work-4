namespace LabWork4
{
    internal class ComplexNumber
    {
        private double r;
        private double fi;

        public ComplexNumber(double r, double fi)
        {
            this.r = r;
            this.fi = fi;
        }

        public ComplexNumber(int realPart, int imaginaryPart)
        {
            this.r = Math.Pow((Math.Pow(realPart, 2) + Math.Pow(imaginaryPart, 2)), 0.5);
            this.fi = getArgComplexNumber(realPart, imaginaryPart);
        }

        public ComplexNumber Power(double n)
        {
            return new ComplexNumber(Math.Pow(r, n), n * fi);
        }
        
        public override string ToString()
        {
            return $"{r} * (cos({fi}) + i * sin({fi}))";
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            // Преобразование к алгебраической форме и выполнение сложения
            double aRe = a.r * Math.Cos(a.fi);
            double aIm = a.r * Math.Sin(a.fi);
            double bRe = b.r * Math.Cos(b.fi);
            double bIm = b.r * Math.Sin(b.fi);

            double resultRe = aRe + bRe;
            double resultIm = aIm + bIm;

            // Преобразование обратно в тригонометрическую форму
            double resultP = Math.Sqrt(resultRe * resultRe + resultIm * resultIm);
            double resultFi = Math.Atan2(resultIm, resultRe);

            return new ComplexNumber(resultP, resultFi);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            // Преобразование к алгебраической форме и выполнение вычитания
            double aRe = a.r * Math.Cos(a.fi);
            double aIm = a.r * Math.Sin(a.fi);
            double bRe = b.r * Math.Cos(b.fi);
            double bIm = b.r * Math.Sin(b.fi);

            double resultRe = aRe - bRe;
            double resultIm = aIm - bIm;

            // Преобразование обратно в тригонометрическую форму
            double resultP = Math.Sqrt(resultRe * resultRe + resultIm * resultIm);
            double resultFi = Math.Atan2(resultIm, resultRe);

            return new ComplexNumber(resultP, resultFi);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            // Выполнение умножения в тригонометрической форме
            double resultP = a.r * b.r;
            double resultFi = a.fi + b.fi;

            return new ComplexNumber(resultP, resultFi);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            // Выполнение деления в тригонометрической форме
            double resultP = a.r / b.r;
            double resultFi = a.fi - b.fi;

            return new ComplexNumber(resultP, resultFi);
        }

        static public double getArgComplexNumber(double a, double b)
        {
            //Возвращает аргумент комплексного числа по таблице
            if (a > 0 && b >= 0)
            {
                return Math.Atan(b / a);
            }
            else if (a < 0 && b >= 0)
            {
                return Math.PI - Math.Atan(Math.Abs(b / a));
            }
            else if (a < 0 && b < 0)
            {
                return Math.PI + Math.Atan(Math.Abs(b / a));
            }
            else if (a > 0 && b < 0)
            {
                return 2 * Math.PI - Math.Atan(Math.Abs(b / a));
            }
            else if (a == 0 && b > 0)
            {
                return Math.PI / 2;
            }
            else if (a == 0 && b < 0)
            {
                return (3 * Math.PI) / 2;
            }
            else
            {
                return b / a;
            }
        }


    }
}
