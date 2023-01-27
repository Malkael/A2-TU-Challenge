using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            if (isInOrder(1, 2) == IsInOrder(1, 2))
            {
                while (IsListInOrder(toSort) == false)
                {
                    for (int i = 1; i <= toSort.Count - 1; i++)
                    {
                        if (isInOrder(toSort[i - 1], toSort[i]) == -1)
                        {
                            int temp;
                            temp = toSort[i - 1];
                            toSort[i - 1] = toSort[i];
                            toSort[i] = temp;
                        }
                    }
                }
            }
            else
            {
                while (IsListInOrderDesc(toSort) == false)
                {
                    for (int i = 1; i <= toSort.Count - 1; i++)
                    {
                        if (isInOrder(toSort[i - 1], toSort[i]) == -1)
                        {
                            int temp;
                            temp = toSort[i - 1];
                            toSort[i - 1] = toSort[i];
                            toSort[i] = temp;
                        }
                    }
                }
            }
            return toSort;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i) == true)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static bool IsDivisible(int a, int b)
        {
            double test = (double)a / b;
            int result = a / b;
            if (test == result)
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a > b)
            {
                return -1;
            }
            else
                return 0;
        }

        public static int IsInOrderDesc(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }
            else
                return 0;
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 1; i <= list.Count - 1; i++)
            {
                if (IsInOrder(list[i - 1], list[i]) == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsListInOrderDesc(List<int> list)
        {
            for (int i = 1; i <= list.Count - 1; i++)
            {
                if (IsInOrderDesc(list[i - 1], list[i]) == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0)
                throw new ArgumentException();
            if (age > 141)
                throw new ArgumentException();
            if (age < 18)
                return false;
            else
                return true;
        }

        public static bool IsPrimary(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;

        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            while (IsListInOrder(toSort) == false)
            {
                for (int i = 1; i <= toSort.Count - 1; i++)
                {
                    if (IsInOrder(toSort[i - 1], toSort[i]) == -1)
                    {
                        int temp;
                        temp = toSort[i - 1];
                        toSort[i - 1] = toSort[i];
                        toSort[i] = temp;
                    }
                }
            }
            return toSort;
        }
    }
}
