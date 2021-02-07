using System;

namespace Lesson_9
{
    static class ArrayHelper
    {
            public static T Pop<T>(ref T[] V)
            {
                T Temp = default;
              
                if (V.Length != 0)
                {
                    Temp = V[V.Length - 1];
                    Array.Resize(ref V, V.Length - 1);
                }
                else
                    Console.WriteLine("Array is empty ");
                return Temp;

            }
            public static int Push<T>(ref T[] V, T x)
            {
                Array.Resize(ref V, V.Length + 1);
                V[V.Length - 1] = x;
                return V.Length;
            }
          
            public static T Shift<T>(ref T[] V)
            {
                T Temp = default;
                if (V.Length != 0)
                {
                    Array.Reverse(V);
                    Temp = V[V.Length - 1];
                    Array.Resize(ref V, V.Length - 1);
                    Array.Reverse(V);
                }
                else
                    Console.WriteLine("Array is empty");

                return Temp;
            }
           
            public static int UnShift<T>(ref T[] V, T x)
            {
                Array.Reverse(V);
                Array.Resize(ref V, V.Length + 1);
                V[V.Length - 1] = x;
                Array.Reverse(V);
                return V.Length;
            }
            public static T[] Slice<T>(ref T[] V)
            {
                T[] NewV = new T[V.Length];
                for (int i = 0; i < V.Length; i++)
                {
                    NewV[i] = V[i];
                }
                return NewV;    
            }
            public static T[] Slice<T>(ref T[] V,int x)//with Begin
            {
                T[] NewV = default;
                if (V.Length != 0)
                {
                    NewV = new T[V.Length - x];
                    for (int i =x; i <V.Length; i ++ )
                        NewV[i - x] = V[i];
                }
                else
                    Console.WriteLine("Array is empty");

                return NewV;
            }
            public static T[] Slice<T>(ref T[] V,int x, int y)// with begin and end;
            {
                T[] NewV = default;
                if (V.Length != 0)
                {
                    NewV = new T[y-x];
                    for (int i = x; i < y; i++)
                        NewV[i - x] = V[i];
                }
                else
                    Console.WriteLine("Array is empty");

                return NewV;
            }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] V1 = { "aa", "bb", "cc", "dd" };
            Console.WriteLine("Our Array ");
            for (int i = 0; i < V1.Length; i++)
                Console.Write(V1[i] + " ");
            Console.WriteLine();
            //Console.WriteLine(ArrayHelper.Slice(ref V1,1,3));
            Console.WriteLine();
            string[] V2 = ArrayHelper.Slice(ref V1, 1, 3);
            Console.Write("Our NewV Array contains:  ");
            for (int i = 0; i < V2.Length; i++)
                Console.Write(V2[i] + " ");
        }
    }
}
