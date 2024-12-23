namespace Web.UI.Classes
{
    internal class NumberModifier
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }

        public int Modulus(int a, int b)
        {
            return a % b;
        }

        public int Increment(int a)
        {
            return a + 1;
        }

        public int Decrement(int a)
        {
            return a - 1;
        }

        public int Negate(int a)
        {
            return -a;
        }

        public int Abs(int a)
        {
            return Math.Abs(a);
        }

        public int Pow(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public int Sqrt(int a)
        {
            return (int)Math.Sqrt(a);
        }

        public int Log(int a)
        {
            return (int)Math.Log(a);
        }

        public int Log10(int a)
        {
            return (int)Math.Log10(a);
        }

        public int Log2(int a)
        {
            return (int)Math.Log2(a);
        }

        public int Round(double a)
        {
            return (int)Math.Round(a);
        }

        public int Floor(double a)
        {
            return (int)Math.Floor(a);
        }

        public int Ceiling(double a)
        {
            return (int)Math.Ceiling(a);
        }

        public int Truncate(double a)
        {
            return (int)Math.Truncate(a);
        }

        public int Max(int a, int b)
        {
            return Math.Max(a, b);
        }

        public int Min(int a, int b)
        {
            return Math.Min(a, b);
        }

        public int Clamp(int a, int min, int max)
        {
            return Math.Clamp(a, min, max);
        }

        public int Sign(int a)
        {
            return Math.Sign(a);
        }

        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int LCM(int a, int b)
        {
            return (a / GCD(a, b)) * b;
        }


    }
}