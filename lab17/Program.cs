using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Check<int> check1 = new Check<int>();
            check1.Write();
            check1.Print();

            Check<string> check2 = new Check<string>();
            check2.Write();
            check2.Print();

            Check<double> check3 = new Check<double>();
            check3.Write();
            check3.Print();

            Console.ReadKey();
        }
    }
    class Check <T>
    {
        T number;
        double balance;
        string fio;


        public void Write()
        {
            Console.WriteLine("Введите номер счета");
            string strNumber = Console.ReadLine();
            number = (T)Convert.ChangeType(strNumber, typeof(T));

            Console.WriteLine("Введите баланс счета");
            balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ФИО владельца счета");
            fio = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("Номер счета: {0}", number);
            Console.WriteLine("Баланс счета: {0}", balance);
            Console.WriteLine("ФИО владельца счета: {0}", fio);
        }
    }
}
