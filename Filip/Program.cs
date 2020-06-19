using System;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Filip:
            // https://open.kattis.com/problems/filip

            var twoNums = Convert2Nums(ReverseOrderArguement(EnterLineString()));
            Console.WriteLine(Math.Max(twoNums[0], twoNums[1]));
        }
        private static int[] Convert2Nums(string[] arr)
        {
            int[] res = new int[2] { 0, 0 };
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i] = int.Parse(arr[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message+" || "+ex.GetType().ToString());
                return Convert2Nums(ReverseOrderArguement(EnterLineString()));
            }
            return res;
        }

        private static string[] EnterLineString()
        {
            string[] strArr = new string[2] { "", "" };
            try
            {
                strArr = Console.ReadLine().Split(' ', 2);
                if (ConditionsString(strArr[0]) == false || ConditionsString(strArr[1]) == false)
                    throw new FormatException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + " || " + ex.GetType().ToString());
                return EnterLineString();
            }
            return strArr;
        }
        private static bool ConditionsString(string str)
        {
            if (str.Length != 3)
                return false;
            else if (str.Contains('0') == true)
                return false;
            else
                return true;
        }
        private static string[] ReverseOrderArguement(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Reverse3CharOrder(arr[i]);
            }
            return arr;
        }
        private static string Reverse3CharOrder(string str)
        {
            // ABC  --> CBA
            char[] arr= str.ToCharArray();
            return arr[2].ToString() + arr[1].ToString() + arr[0].ToString();
        }
    }
}
