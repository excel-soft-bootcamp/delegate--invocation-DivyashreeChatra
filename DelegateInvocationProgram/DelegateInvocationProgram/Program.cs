using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocationProgram
{
    class Program
    {
        static double Calculate(int x, double y) { return x + y; }

        void Update(int newNumber) { System.Console.WriteLine(newNumber); }

        void Delete(string key) { }
        public void M1(){ }
        public void M2(string data) { }
        public int M3(int data1) { return data1; }
        public bool M4(string data,string newdata) { return true; }

        static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4,Func<int, double, double> obj5,Action<int>obj6,Action<string>obj7)
        {
            obj.Invoke();
            obj2.Invoke("Divya");
            obj3.Invoke(5);
            obj4.Invoke("true", "false");
            double calculation = obj5.Invoke(6, 6.2);
            obj6.Invoke(12);
            obj7.Invoke("delete");
            Console.WriteLine(calculation);

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Action m1ptr = new Action(obj.M1);
            Action<string> m2ptr = new Action<string>(obj.M2);
            Func<int,int>m3ptr = new Func<int,int>(obj.M3);
            Func<string, string, bool> m4ptr = new Func<string, string, bool>(obj.M4);
            Func<int, double, double> calculate = new Func<int, double, double>(Program.Calculate);
            Action<int> update = new Action<int>(obj.Update);
            Action<string> delete = new Action<string>(obj.Delete);
            FunctionsAsAnArguments(m1ptr, m2ptr, m3ptr, m4ptr,calculate,update,delete);
        }
    }
}
