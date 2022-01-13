//havent finish all the functions yet
using System;
using System.Collections.Generic;
using System.Linq;

namespace Python.statistics
{
    public static class statistics
    {
        public enum method
        {
            inclusive, 
            exclusive
        }
        public static double mean(float[] data)
        {
            double e = 0;
            for (int i = 0; i < data.Length; i++)
            {
                e += data[i];
            }
            return e / data.Length;
        }
        public static double mean(double[] data)
        {
            double e = 0;
            for (int i = 0; i < data.Length; i++)
            {
                e += data[i];
            }
            return e / data.Length;
        }
        public static double mean(decimal[] data)
        {
            double e = 0;
            for (int i = 0; i < data.Length; i++)
            {
                e += (double)data[i];
            }
            return e / data.Length;
        }
        public static double geometric_mean(float[] data)
        {
            double x = 1;
            for (int i = 0; i < data.Length; i++)
            {
                x *= data[i];
            }
            return Math.Pow(x, 1.0 / data.Length);
        }
        public static double geometric_mean(double[] data)
        {
            double x = 1;
            for (int i = 0; i < data.Length; i++)
            {
                x *= data[i];
            }
            return Math.Pow(x, 1.0 / data.Length);
        }
        public static double geometric_mean(decimal[] data)
        {
            double x = 1;
            for (int i = 0; i < data.Length; i++)
            {
                x *= (double)data[i];
            }
            return Math.Pow(x, 1.0 / data.Length);
        }
        public static double harmonic_mean(float[] data)
        {
            double x = 0;
            foreach (var c in data)
            {
                x += 1.0 / c;
            }
            return data.Length / x;
        }
        public static double harmonic_mean(double[] data)
        {
            double x = 0;
            foreach (var c in data)
            {
                x += 1.0 / c;
            }
            return data.Length / x;
        }
        public static double harmonic_mean(decimal[] data)
        {
            double x = 0;
            foreach (var c in data)
            {
                x += 1.0 / (double)c;
            }
            return data.Length / x;
        }
        public static double harmonic_mean(float[] data, float[] weights)
        {
            double x = 0;
            double y = 0;
            for(int i = 0; i < data.Length; i++)
            {
                x += weights[i] / data[i];
                y += weights[i];
            }
            return y / x;
        }
        public static double harmonic_mean(double[] data, double[] weights)
        {
            double x = 0;
            double y = 0;
            for (int i = 0; i < data.Length; i++)
            {
                x += weights[i] / data[i];
                y += weights[i];
            }
            return y / x;
        }
        public static double harmonic_mean(decimal[] data, decimal[] weights)
        {
            double x = 0;
            double y = 0;
            for (int i = 0; i < data.Length; i++)
            {
                x += (double)(weights[i] / data[i]);
                y += (double)weights[i];
            }
            return y / x;
        }
        public static double median(float[] sourceNumbers)
        {    
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                throw new Exception("Median of empty array not defined.");

            float[] sortedPNumbers = (float[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);
            int mid = sortedPNumbers.Length >> 1;
            float median = ((sortedPNumbers.Length & 1) == 1) ? sortedPNumbers[mid] : (sortedPNumbers[mid] + sortedPNumbers[mid - 1]) / 2;
            return median;
        }
        public static double median(double[] sourceNumbers)
        {
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                throw new Exception("Median of empty array not defined.");

            double[] sortedPNumbers = (double[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);
            int mid = sortedPNumbers.Length >> 1;
            double median = ((sortedPNumbers.Length & 1) == 1) ? sortedPNumbers[mid] : (sortedPNumbers[mid] + sortedPNumbers[mid - 1]) / 2;
            return median;
        }
        public static double median(decimal[] sourceNumbers)
        {
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                throw new Exception("Median of empty array not defined.");

            decimal[] sortedPNumbers = (decimal[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);
            int mid = sortedPNumbers.Length >> 1;
            double median = ((sortedPNumbers.Length & 1) == 1) ? (double)sortedPNumbers[mid] : (double)((sortedPNumbers[mid] + sortedPNumbers[mid - 1]) / 2);
            return median;
        }
        public static double median_high(float[] data)
        {
            Array.Sort(data);
            return data[data.Length >> 1];
        }
        public static double median_high(double[] data)
        {
            Array.Sort(data);
            return data[data.Length >> 1];
        }
        public static double median_high(decimal[] data)
        {
            Array.Sort(data);
            return (double)data[data.Length >> 1];
        }
        public static double median_low(float[] data)
        {
            Array.Sort(data);
            if ((data.Length & 1) == 0)
            {
                return Math.Min(data[data.Length >> 1], data[(data.Length >> 1) - 1]);
            }
            return data[data.Length >> 1];
        }
        public static double median_low(double[] data)
        {
            Array.Sort(data);
            if ((data.Length & 1) == 0)
            {
                return Math.Min(data[data.Length >> 1], data[(data.Length >> 1) - 1]);
            }
            return data[data.Length >> 1];
        }
        public static double median_low(decimal[] data)
        {
            Array.Sort(data);
            if ((data.Length & 1) == 0)
            {
                return (double)Math.Min(data[data.Length >> 1], data[(data.Length >> 1) - 1]);
            }
            return (double)data[data.Length >> 1];
        }
        public static double median_grouped(float[] data, float interval= 1)
        {
            Array.Sort(data);
            int n = data.Length;
            if(n == 1)
            {
                return data[0];
            }
            double x = data[n >> 1];
            double L = x - interval / 2;
            int l1;
            {
                int hi = n;
                int lo = 0;
                while (lo < hi)
                {
                    int mid = (lo + hi) >> 1;
                    if (x < data[mid])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid;
                    }
                }
                l1 = lo;
            }
            int l2;
            {
                int hi = n;
                int lo = l1;
                while (lo < hi)
                {
                    int mid = (lo + hi) >> 1;
                    if (x < data[mid])
                    {
                        hi = mid;
                    }
                    else
                    {
                        lo = mid + 1;
                    }
                }
                l2 = lo;
            }
            int cf = l1;
            int f = l2 - l1 + 1;
            return L + interval * (n / 2 - cf) / f;
        }
        public static double median_grouped(double[] data, double interval = 1)
        {
            Array.Sort(data);
            int n = data.Length;
            if (n == 1)
            {
                return data[0];
            }
            double x = data[n >> 1];
            double L = x - interval / 2;
            int l1;
            {
                int hi = n;
                int lo = 0;
                while (lo < hi)
                {
                    int mid = (lo + hi) >> 1;
                    if (x < data[mid])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid;
                    }
                }
                l1 = lo;
            }
            int l2;
            {
                int hi = n;
                int lo = l1;
                while (lo < hi)
                {
                    int mid = (lo + hi) >> 1;
                    if (x < data[mid])
                    {
                        hi = mid;
                    }
                    else
                    {
                        lo = mid + 1;
                    }
                }
                l2 = lo;
            }
            int cf = l1;
            int f = l2 - l1 + 1;
            return L + interval * (n / 2 - cf) / f;
        }
        public static double median_grouped(decimal[] data, decimal interval = 1)
        {
            Array.Sort(data);
            int n = data.Length;
            if (n == 1)
            {
                return (double)data[0];
            }
            decimal x = data[n >> 1];
            decimal L = x - interval / 2;
            int l1;
            {
                int hi = n;
                int lo = 0;
                while (lo < hi)
                {
                    int mid = (lo + hi) >> 1;
                    if (x < data[mid])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid;
                    }
                }
                l1 = lo;
            }
            int l2;
            {
                int hi = n;
                int lo = l1;
                while (lo < hi)
                {
                    int mid = (lo + hi) >> 1;
                    if (x < data[mid])
                    {
                        hi = mid;
                    }
                    else
                    {
                        lo = mid + 1;
                    }
                }
                l2 = lo;
            }
            int cf = l1;
            int f = l2 - l1 + 1;
            return (double)(L + interval * (n / 2 - cf) / f);
        }
        public static IEnumerable<T> multimode<T>(IEnumerable<T> input)
        {
            var dict = input.ToLookup(x => x);
            if (dict.Count == 0)
                return Enumerable.Empty<T>();
            var maxCount = dict.Max(x => x.Count());
            return dict.Where(x => x.Count() == maxCount).Select(x => x.Key);
        }
        public static T mode<T>(IEnumerable<T> input) => multimode(input).ToArray()[0];
        public static double[] quantiles(float[] data, int n = 4, method method1 = method.exclusive)
        {
            if(n < 1)
            {
                throw new ArgumentException("n must be at least 1");
            }
            Array.Sort(data);
            int ld = data.Length;
            if (method1 == method.inclusive)
            {
                int m = ld - 1;
                List<double> result = new List<double>();
                int j, delta, h;
                for (int i = 1; i < n; i++)
                {
                    h = (i * m);
                    j = h / n;
                    delta = h % n;
                    result.Add((data[j] * (n - delta) + data[j + 1] * delta) / n);
                }
                return result.ToArray();
            }
            else
            {
                int m = ld + 1;
                List<double> result = new List<double>();
                int j, delta, h;
                for (int i = 1; i < n; i++)
                {
                    h = i * m;
                    j = h / n;
                    j = (j < 1) ? 1 : ((j > ld - 1) ? ld - 1 : j);
                    delta = h - j * n;
                    result.Add((data[j - 1] * (n - delta) + data[j] * delta) / n);
                }
                return result.ToArray();
            }
        }
        public static double[] quantiles(double[] data, int n = 4, method method1 = method.exclusive)
        {
            if (n < 1)
            {
                throw new ArgumentException("n must be at least 1");
            }
            Array.Sort(data);
            int ld = data.Length;
            if (method1 == method.inclusive)
            {
                int m = ld - 1;
                List<double> result = new List<double>();
                int j, delta, h;
                for (int i = 1; i < n; i++)
                {
                    h = (i * m);
                    j = h / n;
                    delta = h % n;
                    result.Add((data[j] * (n - delta) + data[j + 1] * delta) / n);
                }
                return result.ToArray();
            }
            else
            {
                int m = ld + 1;
                List<double> result = new List<double>();
                int j, delta, h;
                for (int i = 1; i < n; i++)
                {
                    h = i * m;
                    j = h / n;
                    j = (j < 1) ? 1 : ((j > ld - 1) ? ld - 1 : j);
                    delta = h - j * n;
                    result.Add((data[j - 1] * (n - delta) + data[j] * delta) / n);
                }
                return result.ToArray();
            }
        }
        public static double[] quantiles(decimal[] data, int n = 4, method method1 = method.exclusive)
        {
            if (n < 1)
            {
                throw new ArgumentException("n must be at least 1");
            }
            Array.Sort(data);
            int ld = data.Length;
            if (method1 == method.inclusive)
            {
                int m = ld - 1;
                List<double> result = new List<double>();
                int j, delta, h;
                for (int i = 1; i < n; i++)
                {
                    h = (i * m);
                    j = h / n;
                    delta = h % n;
                    result.Add((double)((data[j] * (n - delta) + data[j + 1] * delta) / n));
                }
                return result.ToArray();
            }
            else
            {
                int m = ld + 1;
                List<double> result = new List<double>();
                int j, delta, h;
                for (int i = 1; i < n; i++)
                {
                    h = i * m;
                    j = h / n;
                    j = (j < 1) ? 1 : ((j > ld - 1) ? ld - 1 : j);
                    delta = h - j * n;
                    result.Add((double)((data[j - 1] * (n - delta) + data[j] * delta) / n));
                }
                return result.ToArray();
            }
        }
    }
}
