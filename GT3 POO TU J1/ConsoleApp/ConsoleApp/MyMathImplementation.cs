using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int i, int i1)
        {
            int result;
            result = i1+ i;

            return result;

        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age > 149)
            {
                throw new ArgumentException();
            }

            if (age < 18)
            {
                return false;
            }
            return true;

        }

        public static bool IsEven(int i)
        {
            if (i % 2 == 0) { 
                return true;
            }
            return false;
        }

        public static bool IsDivisible(int i, int i1)
        {
            if (i % i1 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsPrimary(int i)
        {
            for (int j = 2; j < i; j++) { 
                if (i % j == 0) { 
                    return false;
                }
            }
            return true;
        }

        public static List<int> GetAllPrimary(int i)
        {
            List<int> list = new List<int>();

            for (int j = 2; j <= i; j++) {

                if (IsPrimary(j) == true)
                {
                    list.Add(j);
                }
            }

            return list;
        }

        public static int Power2(int i)
        {
            return i * i;
        }

        public static int Power(int i, int i1)
        {
            int res=1;
            for (int j = 0; j < i1; j++) {
                res *= i;
            }
            return res;
        }

        public static int IsInOrder(int i, int i1)
        {
            if (i < i1) { return 1; }
            if (i > i1) { return -1; }
            else { return 0; }
        }

        public static bool IsListInOrder(List<int> p0)
        {
            int len = p0.Count;
            for (int i = 0; i < len -1; i++) {
                if (IsInOrder(p0[i], p0[i + 1]) == -1) {
                    return false;
                }
            }
            return true;
        }

        public static List<int> Sort(List<int> toSort)
        {
            int len = toSort.Count;
            while (IsListInOrder(toSort) == false)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (IsInOrder(toSort[j], toSort[j + 1]) == -1)
                    {
                        int a = 0;
                        a = toSort[j];

                        toSort[j] = toSort[j + 1];
                        toSort[j + 1] = a;

                    }

                }
            }
            return toSort;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            int len = toSort.Count;
            while (IsListInOrder(toSort) == false)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (isInOrder(toSort[j], toSort[j + 1]) == -1)
                    {
                        int a = 0;
                        a = toSort[j];

                        toSort[j] = toSort[j + 1];
                        toSort[j + 1] = a;

                    }

                }
            }
            return toSort;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            if (arg2 < arg1) { return 1; }
            if (arg2 > arg1) { return -1; }
            else { return 0; }
        }
    }
}