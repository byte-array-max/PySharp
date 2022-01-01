using System;

namespace Python.math
{
    public static class math
    {
        public static decimal ceil(decimal val)
        {
            return Math.Ceiling(val);
        }
        public static double ceil(double val)
        {
            return Math.Ceiling(val);
        }
        public static int comb(int n,int k)
        {
            if (k > n || n == 0)
            {
                return 0;
            }
            else if(n < 0 || k < 0)
            {
                throw new ArgumentException("n or k cannot be a negative integer");
            }
            else
            {
                return (int)(factorial(n) / (factorial(k) * factorial(n - k)));
            }
        }
        public static double copysign(double x, double y)
        {
            if(y < 0)
            {
                return -Math.Abs(x);
            }
            else
            {
                return Math.Abs(x);
            }
        }
        public static sbyte copysign(sbyte x, sbyte y)
        {
            if (y < 0)
            {
                return (sbyte)-Math.Abs(x);
            }
            else
            {
                return Math.Abs(x);
            }
        }
        public static short copysign(short x, short y)
        {
            if (y < 0)
            {
                return (short)-Math.Abs(x);
            }
            else
            {
                return Math.Abs(x);
            }
        }
        public static int copysign(int x, int y)
        {
            if (y < 0)
            {
                return -Math.Abs(x);
            }
            else
            {
                return Math.Abs(x);
            }
        }
        public static long copysign(long x, long y)
        {
            if (y < 0)
            {
                return -Math.Abs(x);
            }
            else
            {
                return Math.Abs(x);
            }
        }
        public static float copysign(float x, float y)
        {
            if (y < 0)
            {
                return -Math.Abs(x);
            }
            else
            {
                return Math.Abs(x);
            }
        }
        public static decimal copysign(decimal x, decimal y)
        {
            if (y < 0)
            {
                return -Math.Abs(x);
            }
            else
            {
                return Math.Abs(x);
            }
        }
        public static sbyte fabs(sbyte val)
        {
            return Math.Abs(val);
        }
        public static short fabs(short val)
        {
            return Math.Abs(val);
        }
        public static int fabs(int val)
        {
            return Math.Abs(val);
        }
        public static long fabs(long val)
        {
            return Math.Abs(val);
        }
        public static decimal fabs(decimal val)
        {
            return Math.Abs(val);
        }
        public static double fabs(double val)
        {
            return Math.Abs(val);
        }
        public static float fabs(float val)
        {
            return Math.Abs(val);
        }
        public static ulong factorial(int val)
        {
            if ((val == 0) || (val == 1))
            {
                return 1;
            }
            else if (val == 2)
            {
                return 2;
            }
            else if (val < 0)
            {
                throw new ArgumentException("value cannot be negative integer");
            }
            else
            {
                ulong b = 2;
                for (uint i = 3; i < val + 1; i++)
                {
                    b *= i;
                }
                return b;
            }
        }
        public static ulong factorial(ulong val)
        {
            if ((val == 0) || (val == 1))
            {
                return 1;
            }
            else if (val == 2)
            {
                return 2;
            }
            else
            {
                ulong b = 2;
                for (ulong i = 3; i < val + 1; i++)
                {
                    b *= i;
                }
                return b;
            }
        }
        public static double floor(double x)
        {
            return Math.Floor(x);
        }
        public static decimal floor(decimal x)
        {
            return Math.Floor(x);
        }
        public static (decimal, int) frexp(byte d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            decimal mantissa = d / (1 << exponent);
            return (mantissa, exponent);
        }
        public static (decimal, int) frexp(sbyte d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            decimal mantissa = d / (1 << exponent);
            return (mantissa, exponent);
        }
        public static (decimal, int) frexp(ushort d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            decimal mantissa = d / (1 << exponent);
            return (mantissa, exponent);
        }
        public static (decimal, int) frexp(short d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            decimal mantissa = d / (1 << exponent);
            return (mantissa, exponent);
        }
        public static (decimal, int) frexp(int d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            decimal mantissa = d / (1 << exponent);
            return (mantissa, exponent);
        }
        public static (decimal, int) frexp(uint d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            decimal mantissa = d / (1 << exponent);
            return (mantissa, exponent);
        }
        public static (decimal, int) frexp(ulong d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            decimal mantissa = d / (ulong)(1 << exponent);
            return (mantissa, exponent);
        }
        public static (decimal, int) frexp(long d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            decimal mantissa = d / (1 << exponent);
            return (mantissa, exponent);
        }
        public static (decimal, int) frexp(double d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            double mantissa = d / (1 << exponent);
            return ((decimal)mantissa, exponent);
        }
        public static (decimal, int) frexp(float d)
        {
            double log2 = (Math.Log(d) / Math.Log(2)) + 1;
            int exponent = (int)log2;
            double mantissa = d / (1 << exponent);
            return ((decimal)mantissa, exponent);
        }
        public static sbyte gcd(sbyte a, sbyte b)
        {
            sbyte tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = (sbyte)(b % a);
                b = tmp;
            }
            return b;
        }
        public static byte gcd(byte a, byte b)
        {
            byte tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = (byte)(b % a);
                b = tmp;
            }
            return b;
        }
        public static short gcd(short a, short b)
        {
            short tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = (short)(b % a);
                b = tmp;
            }
            return b;
        }
        public static ushort gcd(ushort a, ushort b)
        {
            ushort tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = (ushort)(b % a);
                b = tmp;
            }
            return b;
        }
        public static int gcd(int a, int b)
        {
            int tmp;
            while(!(a == 0))
            {
                tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }
        public static uint gcd(uint a, uint b)
        {
            uint tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }
        public static long gcd(long a, long b)
        {
            long tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }
        public static ulong gcd(ulong a, ulong b)
        {
            ulong tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }
        public static double gcd(double a, double b)
        {
            double tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }
        public static float gcd(float a, float b)
        {
            float tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }
        public static decimal gcd(decimal a, decimal b)
        {
            decimal tmp;
            while (!(a == 0))
            {
                tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }
        public static bool isclose(double a, double b,double rel_tol = 1e-09,double abs_tol = 0)
        {
            return Math.Abs(a - b) <= Math.Max(rel_tol * Math.Max(Math.Abs(a), Math.Abs(b)), abs_tol);
        }
        public static bool isclose(float a, float b, double rel_tol = 1e-09, double abs_tol = 0)
        {
            return Math.Abs(a - b) <= Math.Max(rel_tol * Math.Max(Math.Abs(a), Math.Abs(b)), abs_tol);
        }
        public static bool isfinite(double val)
        {
            return !((val == double.NaN) || (val == double.PositiveInfinity) || (val == double.NegativeInfinity));
        }
        public static bool isinf(double val)
        {
            return (val == double.PositiveInfinity) || (val == double.NegativeInfinity);
        }
        public static bool isfinite(float val)
        {
            return !((val == float.NaN) || (val == float.PositiveInfinity) || (val == float.NegativeInfinity));
        }
        public static bool isinf(float val)
        {
            return (val == float.PositiveInfinity) || (val == float.NegativeInfinity);
        }
        public static bool isnan(double val)
        {
            return (val == double.NaN);
        }
        public static bool isnan(float val)
        {
            return (val == float.NaN);
        }
        public static sbyte lcm(sbyte a, sbyte b)
        {
            return (sbyte)(a / gcd(a, b) * b);
        }
        public static byte lcm(byte a, byte b)
        {
            return (byte)(a / gcd(a, b) * b);
        }
        public static short lcm(short a, short b)
        {
            return (short)(a / gcd(a, b) * b);
        }
        public static ushort lcm(ushort a, ushort b)
        {
            return (ushort)(a / gcd(a, b) * b);
        }
        public static int lcm(int a, int b)
        {
            return a / gcd(a, b) * b;
        }
        public static uint lcm(uint a, uint b)
        {
            return a / gcd(a, b) * b;
        }
        public static long lcm(long a, long b)
        {
            return a / gcd(a, b) * b;
        }
        public static ulong lcm(ulong a, ulong b)
        {
            return a / gcd(a, b) * b;
        }
        public static double lcm(double a, double b)
        {
            return a / gcd(a, b) * b;
        }
        public static float lcm(float a, float b)
        {
            return a / gcd(a, b) * b;
        }
        public static decimal lcm(decimal a, decimal b)
        {
            return a / gcd(a, b) * b;
        }
        public static ulong ldexp(decimal x, int i)
        {
            return (ulong)(x * (1 << i));
        }
        public static (decimal, int) modf(double val)
        {
            return ((decimal)(val - (int)val), (int)val);
        }
        public static (decimal, int) modf(float val)
        {
            return ((decimal)(val - (int)val), (int)val);
        }
        public static (decimal, int) modf(decimal val)
        {
            return (val - (int)val, (int)val);
        }
        public static double nextafter(double x, double y)
        {
            if (x < y)
            {
                return (x + double.Epsilon);
            }
            else if (x == y)
            {
                return x;
            }
            else
            {
                return (x - double.Epsilon);
            }
        }
        public static float nextafter(float x, float y)
        {
            if (x < y)
            {
                return (x + float.Epsilon);
            }
            else if (x == y)
            {
                return x;
            }
            else
            {
                return (x - float.Epsilon);
            }
        }
        public static sbyte perm(sbyte n, sbyte k)
        {
            if(n < 0 || k < 0)
            {
                throw new ArgumentException("n or k cannot be a negative integer");
            }
            else if(k > n)
            {
                return 0;
            }
            else
            {
                return (sbyte)(factorial(n) / factorial(n - k));
            }
        }
        public static short perm(short n, short k)
        {
            if (n < 0 || k < 0)
            {
                throw new ArgumentException("n or k cannot be a negative integer");
            }
            else if (k > n)
            {
                return 0;
            }
            else
            {
                return (short)(factorial(n) / factorial(n - k));
            }
        }
        public static int perm(int n, int k)
        {
            if (n < 0 || k < 0)
            {
                throw new ArgumentException("n or k cannot be a negative integer");
            }
            else if (k > n)
            {
                return 0;
            }
            else
            {
                return (int)(factorial(n) / factorial(n - k));
            }
        }
        public static long perm(long n, long k)
        {
            if (n < 0 || k < 0)
            {
                throw new ArgumentException("n or k cannot be a negative integer");
            }
            else if (k > n)
            {
                return 0;
            }
            else
            {
                return (long)(factorial((ulong)n) / factorial((ulong)(n - k)));
            }
        }
        public static byte perm(byte n, byte k)
        {
            if (k > n)
            {
                return 0;
            }
            else
            {
                return (byte)(factorial(n) / factorial(n - k));
            }
        }
        public static ulong perm(ulong n, ulong k)
        {
            if (k > n)
            {
                return 0;
            }
            else
            {
                return (factorial(n) / factorial(n - k));
            }
        }
        public static uint perm(uint n, uint k)
        {
            if (k > n)
            {
                return 0;
            }
            else
            {
                return (uint)(factorial(n) / factorial(n - k));
            }
        }
        public static ushort perm(ushort n, ushort k)
        {
            if (k > n)
            {
                return 0;
            }
            else
            {
                return (ushort)(factorial(n) / factorial(n - k));
            }
        }
        public static long prod(sbyte[] array, int start = 0)
        {
            long x = 1; 
            for(int i = start; i < array.Length;i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static long prod(short[] array, int start = 0)
        {
            long x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static long prod(int[] array, int start = 0)
        {
            long x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static long prod(long[] array, int start = 0)
        {
            long x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static ulong prod(byte[] array, int start = 0)
        {
            ulong x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static ulong prod(ushort[] array, int start = 0)
        {
            ulong x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static ulong prod(uint[] array, int start = 0)
        {
            ulong x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static ulong prod(ulong[] array, int start = 0)
        {
            ulong x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static double prod(double[] array, int start = 0)
        {
            double x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static float prod(float[] array, int start = 0)
        {
            float x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static decimal prod(decimal[] array, int start = 0)
        {
            decimal x = 1;
            for (int i = start; i < array.Length; i++)
            {
                x *= array[i];
            }
            return x;
        }
        public static int trunc(decimal d)
        {
            return (int)d;
        }
        public static int trunc(double d)
        {
            return (int)d;
        }
        public static int trunc(float d)
        {
            return (int)d;
        }
        public static double ulp(double val)
        {
            long bits = BitConverter.DoubleToInt64Bits(val);
            if ((bits & 0x7FF0000000000000L) == 0x7FF0000000000000L)
            {
                if (val == double.NaN)
                {
                    return val;
                }
                return BitConverter.Int64BitsToDouble(0x7FF0000000000000L);
            }
            bits &= 0x7FFFFFFFFFFFFFFFL;
            if (bits == 0x7FEFFFFFFFFFFFFFL)
            {
                return BitConverter.Int64BitsToDouble(bits) - BitConverter.Int64BitsToDouble(bits - 1);
            }
            double nextValue = BitConverter.Int64BitsToDouble(bits + 1);
            double result = nextValue - fabs(val);
            return result;
        }
        public static double exp(sbyte x)
        {
            return Math.Exp(x);
        }
        public static double exp(byte x)
        {
            return Math.Exp(x);
        }
        public static double exp(short x)
        {
            return Math.Exp(x);
        }
        public static double exp(ushort x)
        {
            return Math.Exp(x);
        }
        public static double exp(int x)
        {
            return Math.Exp(x);
        }
        public static double exp(uint x)
        {
            return Math.Exp(x);
        }
        public static double exp(long x)
        {
            return Math.Exp(x);
        }
        public static double exp(ulong x)
        {
            return Math.Exp(x);
        }
        public static double exp(double x)
        {
            return Math.Exp(x);
        }
        public static double exp(decimal x)
        {
            return Math.Exp((double)x);
        }
        public static double exp(float x)
        {
            return Math.Exp(x);
        }
        public static double expm1(double x)
        {
            if (Math.Abs(x) < 1e-5)
                return x + 0.5 * x * x;
            else
                return Math.Exp(x) - 1.0;
        }
        public static double log(sbyte val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(byte val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(ushort val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(short val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(int val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(uint val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(long val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(ulong val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(double val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log(float val, int Base)
        {
            return Math.Log(val, Base);
        }
        public static double log1p(sbyte val)
        {
            return Math.Log(val);
        }
        public static double log1p(byte val)
        {
            return Math.Log(val);
        }
        public static double log1p(ushort val)
        {
            return Math.Log(val);
        }
        public static double log1p(short val)
        {
            return Math.Log(val);
        }
        public static double log1p(int val)
        {
            return Math.Log(val);
        }
        public static double log1p(uint val)
        {
            return Math.Log(val);
        }
        public static double log1p(long val)
        {
            return Math.Log(val);
        }
        public static double log1p(ulong val)
        {
            return Math.Log(val);
        }
        public static double log1p(double val)
        {
            return Math.Log(val);
        }
        public static double log1p(float val)
        {
            return Math.Log(val);
        }
        public static double log2(sbyte val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(byte val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(ushort val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(short val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(int val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(uint val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(long val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(ulong val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(double val)
        {
            return Math.Log(val, 2);
        }
        public static double log2(float val)
        {
            return Math.Log(val, 2);
        }
        public static double log10(sbyte val)
        {
            return Math.Log10(val);
        }
        public static double log10(byte val)
        {
            return Math.Log10(val);
        }
        public static double log10(ushort val)
        {
            return Math.Log10(val);
        }
        public static double log10(short val)
        {
            return Math.Log10(val);
        }
        public static double log10(int val)
        {
            return Math.Log10(val);
        }
        public static double log10(uint val)
        {
            return Math.Log10(val);
        }
        public static double log10(long val)
        {
            return Math.Log10(val);
        }
        public static double log10(ulong val)
        {
            return Math.Log10(val);
        }
        public static double log10(double val)
        {
            return Math.Log10(val);
        }
        public static double log10(float val)
        {
            return Math.Log10(val);
        }
        public static double pow(double x, double y) => Math.Pow(x,y);
        public static double sqrt(sbyte x) => Math.Sqrt(x);
        public static double sqrt(byte x) => Math.Sqrt(x);
        public static double sqrt(short x) => Math.Sqrt(x);
        public static double sqrt(ushort x) => Math.Sqrt(x);
        public static double sqrt(int x) => Math.Sqrt(x);
        public static double sqrt(uint x) => Math.Sqrt(x);
        public static double sqrt(long x) => Math.Sqrt(x);
        public static double sqrt(ulong x) => Math.Sqrt(x);
        public static double sqrt(double x) => Math.Sqrt(x);
        public static double sqrt(float x) => Math.Sqrt(x);
        public static double acos(double x) => Math.Acos(x);
        public static double acos(float x) => Math.Acos(x);
        public static double acos(decimal x) => Math.Acos((double)x);
        public static double asin(double x ) => Math.Asin(x);
        public static double asin(float x  ) => Math.Asin(x);
        public static double asin(decimal x) => Math.Asin((double)x);
        public static double atan(double x ) => Math.Atan(x);
        public static double atan(float x  ) => Math.Atan(x);
        public static double atan(decimal x) => Math.Atan((double)x);
        public static double atan2(double x , double y ) => Math.Atan2(x, y);
        public static double atan2(float x  , float y  ) => Math.Atan2(x, y);
        public static double atan2(decimal x, decimal y) => Math.Atan2((double)x, (double)y);
        public static double cos(double x) =>  Math.Cos(x);
        public static double cos(float x) =>   Math.Cos(x);
        public static double cos(decimal x) => Math.Cos((double)x);
        public static double dist(double x1, double y1, double x2, double y2)
        {
            double distx = Math.Abs(x1 - x2);
            double disty = Math.Abs(y1 - y2);
            return Math.Sqrt((distx * distx) + (disty * disty));
        }
        public static float dist(float x1, float y1, float x2, float y2)
        {
            double distx = Math.Abs(x1 - x2);
            double disty = Math.Abs(y1 - y2);
            return (float)Math.Sqrt((distx * distx) + (disty * disty));
        }
        public static decimal dist(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            double distx = (double)Math.Abs(x1 - x2);
            double disty = (double)Math.Abs(y1 - y2);
            return (decimal)Math.Sqrt((distx * distx) + (disty * disty));
        }
        public static double hypot(double x, double y) => Math.Sqrt(x * x + y * y);
        public static float hypot(float x, float y) => (float)Math.Sqrt(x * x + y * y);
        public static decimal hypot(decimal x, decimal y) => (decimal)Math.Sqrt((double)(x * x + y * y));
        public static double sin(double x) => Math.Sin(x);
        public static float sin(float x) => (float)Math.Sin(x);
        public static decimal sin(decimal x) => (decimal)Math.Sin((double)x);
        public static double tan(double x) => Math.Tan(x);
        public static float tan(float x) => (float)Math.Tan(x);
        public static decimal tan(decimal x) => (decimal)Math.Tan((double)x);
        public static double degrees(double x) => 180 / Math.PI * x;
        public static float degrees(float x) => (float)(180 / Math.PI * x);
        public static decimal degrees(decimal x) => (decimal)(180 / Math.PI) * x;
        public static double radians(double x) => Math.PI / 180 * x;
        public static float radians(float x) => (float)(Math.PI / 180 * x);
        public static decimal radians(decimal x) => (decimal)(Math.PI / 180) * x;
        public static double acosh(double x) => Math.Log(x + Math.Sqrt(x * x + 1));
        public static float acosh(float x) => (float)Math.Log(x + Math.Sqrt(x * x + 1));
        public static decimal acosh(decimal x) => (decimal)Math.Log((double)x + Math.Sqrt((double)(x * x + 1)));
        public static double asinh(double x) => Math.Log(x + Math.Sqrt(x * x - 1));
        public static float asinh(float x) => (float)Math.Log(x + Math.Sqrt(x * x - 1));
        public static decimal asinh(decimal x) => (decimal)Math.Log((double)x + Math.Sqrt((double)(x * x - 1)));
        public static double atanh(double x) => Math.Log((1 + x) / (1 - x)) / 2;
        public static float atanh(float x) => (float)atanh((double)x);
        public static decimal atanh(decimal x) => (decimal)atanh((double)x);
        public static double cosh(double x) => Math.Cosh(x);
        public static double cosh(float x) => Math.Cosh(x);
        public static double cosh(decimal x) => Math.Cosh((double)x);
        public static double sinh(double x) => Math.Sinh(x);
        public static double sinh(float x) => Math.Sinh(x);
        public static double sinh(decimal x) => Math.Sinh((double)x);
        public static double tanh(double x) => Math.Tanh(x);
        public static double tanh(float x) => Math.Tanh(x);
        public static double tanh(decimal x) => Math.Tanh((double)x);
        public static double erf(double x)
        {
            // constants
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            // Save the sign of x
            int sign = (x < 0) ? -1 : 1;
            x = fabs(x);

            // A&S formula 7.1.26
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * exp(-x * x);

            return sign * y;
        }
        public static double erf(float x) => erf((double)x);
        public static decimal erf(decimal x) => (decimal)erf((double)x);
        public static double erfc(double x) => 1 - erf(x);
        public static double erfc(float x) => 1 - erf((double)x);
        public static decimal erfc(decimal x) => 1 - (decimal)erf((double)x);
        public static double gamma(double z)
        {
            double[] p = {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028,
                771.32342877765313, -176.61502916214059, 12.507343278686905,
                -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7
            };
            if (z < 0.5)
                return Math.PI / (Math.Sin(Math.PI * z) * gamma(1 - z));
            z -= 1;
            double x = p[0];
            for (var i = 1; i < 9; i++)
                x += p[i] / (z + i);
            double t = z + 7 + 0.5;
            return Math.Sqrt(2 * Math.PI) * (Math.Pow(t, z + 0.5)) * Math.Exp(-t) * x;
        }
        public static float gamma(float z) => (float)gamma((double)z);
        public static decimal gamma(decimal z) => (decimal)gamma((double)z);
        public static double lgamma(double z) => Math.Log(gamma(z));
        public static double pi
        {
            get
            {
                return Math.PI;
            }
        }
        public static double e
        {
            get
            {
                return Math.E;
            }
        }
        public static double tao
        {
            get
            {
                return 2 * Math.PI;
            }
        }
        public static double inf
        {
            get
            {
                return double.PositiveInfinity;
            }
        }
        public static double nan
        {
            get
            {
                return double.NaN;
            }
        }
    }
}
