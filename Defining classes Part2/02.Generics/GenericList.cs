using System;


    public class GenericList<T>
    {
        //properties
        private int n = 1;
        private T[] array;
        private T[] arrayNew;
        private int count=0;

        // Class Constructor
        public GenericList(int arrayLenght)
        {
            array = new T[arrayLenght];
            this.n = arrayLenght;
        }

        // if no value, the array is made of 1 element
        public GenericList()
        {
            array = new T[1];
        }
        // -------------Methods--------------------
        //  Adds Elemet
        public void AddElement(T value)
        {
            if (count < this.array.Length)
            {
                this.array[this.count] = value;
                
            }
            else
            {
                arrayNew = new T[count*2];
                for (int i = 0; i <count; i++)
                {
                    arrayNew[i] = array[i];
                }
                arrayNew[count] =value;
                this.array = arrayNew;
            }
            count = count + 1;
            
        }
        // Prints array
        public  void PrintArray()
        {
            
           
                for (int i = 0; i < this.array.Length; i++)
                {
                    Console.WriteLine("Array[{0}]={1}", i, this.array[i]);
                }
            
        }
        // Minimum element
        public T Min()
        {
            if (array[0] is IComparable<T>)
            {
                T min = array[0];
                for (int i = 0; i <array.Length; i++)
                {
                    if ((min as IComparable<T>).CompareTo(array[i]) > 0)
                    {
                        min = array[i];
                    }
                }
                return min;
            }
            else throw new TypeAccessException("The list is non-comparable");
        }
        // Maximum element
        public T Max()
        {
            if (array[0] is IComparable<T>)
            {
                T max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if ((max as IComparable<T>).CompareTo(array[i]) < 0)
                    {
                        max = array[i];
                    }
                }
                return max;
            }
            else throw new TypeAccessException("The list is non-comparable");
        } 


    }


        
    class Program
    {
       
        static void Main()
        {
           GenericList<int> list = new GenericList<int>(2);
           list.PrintArray();
           Console.WriteLine("----------------------------------");
           list.AddElement(1);
           list.PrintArray();
           Console.WriteLine("----------------------------------");
           list.AddElement(2);
           list.PrintArray();
           Console.WriteLine("----------------------------------");
           list.AddElement(3);
           list.PrintArray();
           Console.WriteLine("----------------------------------");
           list.AddElement(4);
           list.PrintArray();
           Console.WriteLine("Min element is:" + list.Min());
           Console.WriteLine("Max element is:" + list.Max());
           Console.WriteLine("----------------------------------");
           list.AddElement(5);
           list.PrintArray();
           Console.WriteLine("----------------------------------");
           list.AddElement(6);
           list.PrintArray();
           Console.WriteLine("Min element is:" + list.Min());
           Console.WriteLine("Max element is:" + list.Max());
           Console.WriteLine("----------------------------------");




        }
    }

