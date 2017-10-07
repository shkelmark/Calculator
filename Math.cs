namespace Calculator
{
    public class Maths
    {
        private double Add(double A, double B)
        {
            return A + B;
        }

        private double Sub(double A, double B)
        {
            return A - B;
        }

        private double Mul(double A, double B)
        {
            return A * B;
        }

        private double Div(double A, double B)
        {
            return A / B;
        }

        public double Calculate(double A, double B, int Operate)
        {
            double result = 0;

            switch (Operate)
            {
                case 1:
                    result = Add(A, B);
                    break;

                case 2:
                    result = Sub(A, B);
                    break;

                case 3:
                    result = Mul(A, B);
                    break;

                case 4:
                    result = Div(A, B);
                    break;
            }

            return result;
        }

    }
}
