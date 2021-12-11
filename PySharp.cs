
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Python
{
    public static class PySharp
    {
        public static sbyte abs(sbyte number)
        {
            return Math.Abs(number);
        }
        public static short abs(short number)
        {
            return Math.Abs(number);
        }
        public static int abs(int number)
        {
            return Math.Abs(number);
        }
        public static long abs(long number)
        {
            return Math.Abs(number);
        }
        public static float abs(float number)
        {
            return Math.Abs(number);
        }
        public static decimal abs(decimal number)
        {
            return Math.Abs(number);
        }
        public static double abs(double number)
        {
            return Math.Abs(number);
        }
        public static string bin(sbyte number)
        {
            return Convert.ToString(number, 2);
        }
        public static string bin(byte number)
        {
            return Convert.ToString(number, 2);
        }
        public static string bin(short number)
        {
            return Convert.ToString(number, 2);
        }
        public static string bin(ushort number)
        {
            return Convert.ToString(number, 2);
        }
        public static string bin(int number)
        {
            return Convert.ToString(number, 2);
        }
        public static string bin(uint number)
        {
            return Convert.ToString(number, 2);
        }
        public static string bin(long number)
        {
            return Convert.ToString(number, 2);
        }
        public static string bin(ulong number)
        {
            return Convert.ToString((long)number, 2);
        }
        public static byte[] bytearray(string text)
        {
            byte[] array = new byte[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = (byte)text[i];
            }
            return array;
        }
        public static char chr(sbyte number)
        {
            return (char)number;
        }
        public static char chr(byte number)
        {
            return (char)number;
        }
        public static char chr(short number)
        {
            return (char)number;
        }
        public static char chr(ushort number)
        {
            return (char)number;
        }
        public static char chr(int number)
        {
            return (char)number;
        }
        public static char chr(uint number)
        {
            return (char)number;
        }
        public static char chr(long number)
        {
            return (char)number;
        }
        public static char chr(ulong number)
        {
            return (char)number;
        }
        public static Complex complex(string text)
        {
            string[] array = text.Split('+');
            if (array.Length == 2 && Regex.Replace(array[0], "[0-9]", "") == "" && Regex.Replace(array[1].Substring(0, array[1].Length), "[0-9]", "") == "" && array[1].EndsWith("j"))
            {
                return new Complex(double.Parse(array[0]), double.Parse(array[1].Substring(0, array[1].Length)));
            }
            else
            {
                throw new ArgumentException("Invalid Complex Number");
            }
        }
        public static Complex complex(double real, double imaginary)
        {
            return new Complex(real, imaginary);
        }
        public static Complex complex((double, double) number)
        {
            return new Complex(number.Item1, number.Item2);
        }
        public static (double, double) divmod(double a, double b)
        {
            return (a / b, a % b);
        }
        public static (float, float) divmod(float a, float b)
        {
            return (a / b, a % b);
        }
        public static (decimal, decimal) divmod(decimal a, decimal b)
        {
            return (a / b, a % b);
        }
        public static (sbyte, sbyte) divmod(sbyte a, sbyte b)
        {
            return ((sbyte)(a / b), (sbyte)(a % b));
        }
        public static (byte, byte) divmod(byte a, byte b)
        {
            return ((byte)(a / b), (byte)(a % b));
        }
        public static (short, short) divmod(short a, short b)
        {
            return ((short)(a / b), (short)(a % b));
        }
        public static (ushort, ushort) divmod(ushort a, ushort b)
        {
            return ((ushort)(a / b), (ushort)(a % b));
        }
        public static (int, int) divmod(int a, int b)
        {
            return (a / b, a % b);
        }
        public static (uint, uint) divmod(uint a, uint b)
        {
            return (a / b, a % b);
        }
        public static (long, long) divmod(long a, long b)
        {
            return ((long)(a / b), (long)(a % b));
        }
        public static (ulong, ulong) divmod(ulong a, ulong b)
        {
            return ((ulong)(a / b), (ulong)(a % b));
        }
        public static (int, T)[] enumerate<T>(T[] array, int start = 0)
        {
            (int, T)[] enumarray = new (int, T)[array.Length];
            for (int i = start; i < enumarray.Length + start; i++)
            {
                enumarray[i - start] = (i, array[i]);
            }
            return enumarray;
        }
        public static string hex(sbyte number)
        {
            return Convert.ToString(number, 16);
        }
        public static string hex(byte number)
        {
            return Convert.ToString(number, 16);
        }
        public static string hex(short number)
        {
            return Convert.ToString(number, 16);
        }
        public static string hex(ushort number)
        {
            return Convert.ToString(number, 16);
        }
        public static string hex(int number)
        {
            return Convert.ToString(number, 16);
        }
        public static string hex(uint number)
        {
            return Convert.ToString(number, 16);
        }
        public static string hex(long number)
        {
            return Convert.ToString(number, 16);
        }
        public static string hex(ulong number)

        {
            return Convert.ToString((long)number, 16);
        }
        public static string input<T>(T prompt)
        {
            Console.Write(prompt);
            string a = Console.ReadLine();
            return a;
        }
        public static string input()
        {
            string a = Console.ReadLine();
            return a;
        }
        public static int len<T>(T[] array)
        {
            return array.Length;
        }
        public static int len(string text)
        {
            return text.Length;
        }
        public static string oct(sbyte number)
        {
            return Convert.ToString(number, 8);
        }
        public static string oct(byte number)
        {
            return Convert.ToString(number, 8);
        }
        public static string oct(short number)
        {
            return Convert.ToString(number, 8);
        }
        public static string oct(ushort number)
        {
            return Convert.ToString(number, 8);
        }
        public static string oct(int number)
        {
            return Convert.ToString(number, 8);
        }
        public static string oct(uint number)
        {
            return Convert.ToString(number, 8);
        }
        public static string oct(long number)
        {
            return Convert.ToString(number, 8);
        }
        public static string oct(ulong number)

        {
            return Convert.ToString((long)number, 8);
        }
        public static byte ord(char chr)
        {
            return (byte)chr;
        }
        public static void print<T>(T prompt, ConsoleColor foreground = ConsoleColor.Gray, ConsoleColor background = ConsoleColor.Black)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.WriteLine(prompt);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static sbyte[] range(sbyte start, sbyte stop, sbyte step = 0)
        {
            sbyte[] array = new sbyte[stop - start];
            for (sbyte i = start; i < stop; i += (sbyte)step)
            {
                array[i] = i;
            }
            return array;
        }
        public static byte[] range(byte start, byte stop, byte step = 0)
        {
            byte[] array = new byte[stop - start];
            for (byte i = start; i < stop; i += step)
            {
                array[i] = i;
            }
            return array;
        }
        public static short[] range(short start, short stop, short step = 0)
        {
            short[] array = new short[stop - start];
            for (short i = start; i < stop; i += step)
            {
                array[i] = i;
            }
            return array;
        }
        public static ushort[] range(ushort start, ushort stop, ushort step = 0)
        {
            ushort[] array = new ushort[stop - start];
            for (ushort i = start; i < stop; i += step)
            {
                array[i] = i;
            }
            return array;
        }
        public static int[] range(int start, int stop, int step = 0)
        {
            int[] array = new int[stop - start];
            for (int i = start; i < stop; i += step)
            {
                array[i] = i;
            }
            return array;
        }
        public static uint[] range(uint start, uint stop, uint step = 0)
        {
            uint[] array = new uint[stop - start];
            for (uint i = start; i < stop; i += step)
            {
                array[i] = i;
            }
            return array;
        }
        public static long[] range(long start, long stop, long step = 0)
        {
            long[] array = new long[stop - start];
            for (long i = start; i < stop; i += step)
            {
                array[i] = i;
            }
            return array;
        }
        public static ulong[] range(ulong start, ulong stop, ulong step = 0)
        {
            ulong[] array = new ulong[stop - start];
            for (ulong i = start; i < stop; i += step)
            {
                array[i] = i;
            }
            return array;
        }
        public static sbyte[] range(sbyte number)
        {
            sbyte[] array = new sbyte[number];
            for (sbyte i = 0; i < number; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static byte[] range(byte number)
        {
            byte[] array = new byte[number];
            for (byte i = 0; i < number; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static short[] range(short number)
        {
            short[] array = new short[number];
            for (short i = 0; i < number; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static ushort[] range(ushort number)
        {
            ushort[] array = new ushort[number];
            for (ushort i = 0; i < number; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static int[] range(int number)
        {
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static uint[] range(uint number)
        {
            uint[] array = new uint[number];
            for (uint i = 0; i < number; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static long[] range(long number)
        {
            long[] array = new long[number];
            for (long i = 0; i < number; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static ulong[] range(ulong number)
        {
            ulong[] array = new ulong[number];
            for (ulong i = 0; i < number; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static decimal round(decimal number, int digit = 0)
        {
            string a = "#";
            for (int i = 0; i < digit; i++)
            {
                a += "#";
            }
            return decimal.Parse(number.ToString("#." + a));
        }
        public static float round(float number, int digit = 0)
        {
            string a = "#";
            for (int i = 0; i < digit; i++)
            {
                a += "#";
            }
            return float.Parse(number.ToString("#." + a));
        }
        public static double round(double number, int digit = 0)
        {
            string a = "#";
            for (int i = 0; i < digit; i++)
            {
                a += "#";
            }
            return double.Parse(number.ToString("#." + a));
        }
        public static string str<T>(T typ)
        {
            return typ.ToString();
        }
        public static int sum(sbyte[] iterable, int start = 0)
        {
            int x = 0;
            for (int i = 0; i < iterable.Length; i++)
            {
                x += iterable[i];
            }
            return x + start;
        }
        public static uint sum(byte[] iterable, uint start = 0)
        {
            uint x = 0;
            for (int i = 0; i < iterable.Length; i++)
            {
                x += iterable[i];
            }
            return x + start;
        }
        public static int sum(short[] iterable, int start = 0)
        {
            int x = 0;
            for (int i = 0; i < iterable.Length; i++)
            {
                x += iterable[i];
            }
            return x + start;
        }
        public static uint sum(ushort[] iterable, uint start = 0)
        {
            uint x = 0;
            for (int i = 0; i < iterable.Length; i++)
            {
                x += iterable[i];
            }
            return x + start;
        }
        public static int sum(int[] iterable, int start = 0)
        {
            int x = 0;
            for (int i = 0; i < iterable.Length; i++)
            {
                x += iterable[i];
            }
            return x + start;
        }
        public static ulong sum(uint[] iterable, ulong start = 0)
        {
            ulong x = 0;
            for (int i = 0; i < iterable.Length; i++)
            {
                x += iterable[i];
            }
            return x + start;
        }
        public static long sum(long[] iterable, long start = 0)
        {
            long x = 0;
            for (int i = 0; i < iterable.Length; i++)
            {
                x += iterable[i];
            }
            return x + start;
        }
        public static ulong sum(ulong[] iterable, ulong start = 0)
        {
            ulong x = 0;
            for (int i = 0; i < iterable.Length; i++)
            {
                x += iterable[i];
            }
            return x + start;
        }
        public static string capitalize(this string x)
        {
            return char.ToUpper(x[0]) + x.Substring(1);
        }
        public static string casefold(string text)
        {
            return text.ToLower();
        }
        public static string center(this string text, int length)
        {
            return text.PadLeft(length, ' ');
        }
        public static int count(this string x, string y)
        {
            return x.Split(new string[] { y }, StringSplitOptions.None).Length - 1;
        }
        public static bool endswith(this string text, string word)
        {
            return text.EndsWith(word);
        }
        public static int find(this string text, string value)
        {
            return text.IndexOf(value);
        }
        public static int index(this string text, string value)
        {
            return text.IndexOf(value);
        }
        public static bool isalnum(this string x)
        {
            return Regex.Replace(x, "[^a-zA-Z0-9]", "") == "";
        }
        public static bool isalpha(this string x)
        {
            return Regex.Replace(x, "[a-zA-Z]", "") == "";
        }
        public static bool isascii(this string value)
        {
            return Encoding.UTF8.GetByteCount(value) == value.Length;
        }
        public static bool isdigit(this string x)
        {
            double y = 0;
            return double.TryParse(x, out y);
        }
        public static bool isdecimal(this string x)
        {
            double y = 0;
            return double.TryParse(x, out y);
        }
        public static bool isidentifier(this string x)
        {
            string start = ("abcdefghijklmnopqrstuvwxyz" + "abcdefghijklmnopqrstuvwxyz_".ToUpper());
            string others = start + "0123456789";
            if (start.Contains(Char.ToString(x[0])))
            {
                if (Regex.Replace(x, $"[<{others}>]", "") == "")
                {
                    return true;
                }
            }
            return false;
        }
        public static bool islower(this string x)
        {
            return x == x.ToLower();
        }
        public static bool isnumeric(this string x)
        {
            return Regex.Replace(x, "[0-9]", "") == "";
        }
        public static bool isprintable(this string x)
        {
            var nonRenderingCategories = new UnicodeCategory[] { UnicodeCategory.Control, UnicodeCategory.OtherNotAssigned, UnicodeCategory.Surrogate };
            for (int i = 0; i < x.Length; i++)
            {
                if (Char.IsWhiteSpace(x[i]) || !nonRenderingCategories.Contains(Char.GetUnicodeCategory(x[i])))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool isspace(this string x)
        {
            return "" == x.Replace(" ", "");
        }
        public static bool istitle(this string text)
        {
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsUpper(words[i][0]) && (words[i].Substring(1).ToLower() == words[i].Substring(1)))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool isupper(this string x)
        {
            return x == x.ToUpper();
        }
        public static string join<T>(this string seperator, IEnumerable<T> values)
        {
            return string.Join(seperator, values);
        }
        public static string ljust(this string x, int values, char padchar = ' ')
        {
            return x.PadLeft(values + x.Length, padchar);
        }
        public static string lower(this string x)
        {
            return x.ToLower();
        }
        public static string lstrip(this string x, string charlist = " ")
        {
            return x.TrimStart(charlist.ToCharArray());
        }
        public static (string,string,string) partition(this string text, string word)
        {
            int Index = text.IndexOf(word);
            string[] array = new string[3];
            array[0] = text.Substring(0, Index);
            array[1] = word;
            array[2] = text.Substring(Index + word.Length);
            return (array[0],array[1],array[1]);
        }
        public static string replace(this string text, string oldvalue, string newvalue)
        {
            return text.Replace(oldvalue, newvalue);
        }
        public static int rfind(this string text, string value,int startindex, int count)
        {
            return text.LastIndexOf(value,startindex,count);
        }
        public static int rfind(this string text, string value, int startindex)
        {
            return text.LastIndexOf(value, startindex);
        }
        public static int rfind(this string text, string value)
        {
            return text.LastIndexOf(value);
        }
        public static string rjust(this string x, int values, char padchar = ' ')
        {
            return x.PadRight(values + x.Length, padchar);
        }
        public static (string, string, string) rpartition(this string text, string word)
        {
            int Index = text.LastIndexOf(word);
            string[] array = new string[3];
            array[0] = text.Substring(0, Index);
            array[1] = word;
            array[2] = text.Substring(Index + word.Length);
            return (array[0], array[1], array[1]);
        }
        public static string rstrip(this string x, string charlist = " ")
        {
            return x.TrimEnd(charlist.ToCharArray());
        }
        public static string[] split(this string x, string values)
        {
            return x.Split(new string[] { values },StringSplitOptions.None);
        }
        public static string strip(this string x, string charlist = " ")
        {
            return x.Trim(charlist.ToCharArray());
        }
        public static string swapcase(this string source)
        {
            char[] caseSwappedChars = new char[source.Length];
            for (int i = 0; i < caseSwappedChars.Length; i++)
            {
                char c = source[i];
                if (char.IsLetter(c))
                {
                    caseSwappedChars[i] =
                        char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
                }
                else
                {
                    caseSwappedChars[i] = c;
                }
            }
            return new string(caseSwappedChars);
        }
        public static string title(this string text)
        {
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][i]) + words[i].Substring(1);
            }
            return string.Join(" ", words);
        }
        public static string upper(this string text)
        {
            return text.ToUpper();
        }
        public static string zfill(this string text, int length)
        {
            return text.PadLeft(length, '0');
        }
        public static T[] append<T>(this T[] array, T element)
        {
            List<T> list = array.ToList();
            list.Add(element);
            return list.ToArray();
        }
        public static void clear<T>(this T[] array)
        {
            Array.Clear(array,0,array.Length);
        }
        public static int count<T>(this T[] array, T element)
        {
            int num = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i], element))
                {
                    num++;
                }
            }
            return num;
        }
        public static void extend<T>(this T[] array, T[] values)
        {
            List<T> list = array.ToList();
            list.AddRange(values);
            array = list.ToArray();
        }
        public static int index<T>(this T[] array, T element)
        {
            return Array.IndexOf(array, element);
        }
        public static void insert<T>(this T[] array, int index, T element)
        {
            List<T> list = array.ToList();
            list.Insert(index,element);
            array = list.ToArray();
        }
        public static void pop<T>(this T[] array, int index)
        {
            var list = array.ToList();
            list.RemoveAt(index);
            array = list.ToArray();
        }
        public static void remove<T>(this T[] array, T element)
        {
            var list = array.ToList();
            int indexat = array.index(element);
            list.RemoveAt(indexat);
            array = list.ToArray();
        }
        public static void reverse<T>(this T[] array)
        {
            Array.Reverse(array);
        }
        public static void sort<T>(this T[] array)
        {
            Array.Sort(array);
        }
        public static void clear<T, Y>(this Dictionary<T,Y> dict)
        {
            dict.Clear();
        }
        public static Dictionary<T, Y> fromkeys<T, Y>(T[] array, Y element)
        {
            Dictionary<T, Y> dict = new Dictionary<T, Y>();
            for(int i  = 0; i  < array.Length; i++)
            {
                dict.Add(array[i], element);
            }
            return dict;
        }
        public static T get<T, Y>(this Dictionary<Y, T> array, Y element)
        {
            return array[element];
        }
        public static (Y, T)[] items<T, Y>(this Dictionary<Y, T> array)
        {
            (Y, T)[] value = new (Y, T)[array.Count];
            for(int i = 0; i < array.Count; i++)
            {
                value[i] = (array.ElementAt(i).Key, array.ElementAt(i).Value);
            }
            return value;
        }
        public static Y[] keys<T, Y>(this Dictionary<Y, T> array)
        {
            Y[] value = new Y[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                value[i] = array.ElementAt(i).Key;
            }
            return value;
        }
        public static void pop<T, Y>(this Dictionary<Y, T> array, Y key)
        {
            array.Remove(key);
        }
        public static void popitem<T, Y>(this Dictionary<Y, T> array, Y key)
        {
            array.Remove(array.ElementAt(array.Count-1).Key);
        }
        public static T[] values<T, Y>(this Dictionary<Y, T> array)
        {
            T[] value = new T[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                value[i] = array.ElementAt(i).Value;
            }
            return value;
        }
    }
}
