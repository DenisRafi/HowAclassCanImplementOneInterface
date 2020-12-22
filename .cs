using System;

namespace ByDR
{
    class Program
    {
        static void Main()
        {
            ClassA a = new ClassA();
            a.MyNumber = 10;
            a.InterfaceMethod();
            Console.Read();
        }
    }
    interface IShape
    {
        int MyNumber
        {
            get;
            set;
        }
        void InterfaceMethod();
    }
    class ClassA : IShape
    {
        private int myNumber;
        public int MyNumber
        {
            get
            {
                return myNumber;
            }
            set
            {
                if (value < 0)
                    myNumber = 0;
                else
                    myNumber = value;
            }
        }
        public void InterfaceMethod()
        {
            Console.WriteLine("The number is {0} ", MyNumber);
        }
    }
}