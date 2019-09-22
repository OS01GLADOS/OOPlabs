using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNum2
{
    class Lab2Task3 : IDisposable
    {
        private readonly int balance;

        public Lab2Task3(int refill)
        {
            balance = refill;
        }

        public int AddedMoney() => balance;
        
        public void Dispose()
        {

        }
    }


    class Lab2
    {
        static void FuncCheck()
        {
            checked
            {
                int variableChecked = 2147483647;
                //Console.WriteLine(variableChecked + 2);
            }
        }

        static void FuncUncheck()
        {
            unchecked
            {
                int variableUnchecked = 2147483647;
                //Console.WriteLine(variableUnchecked + 2);
            }
        }

        static void TupleFunc((int, int) tupleOne)
        {
            Console.WriteLine(tupleOne.Item1);
        }

        static void Main(string[] arg)
        {
            Console.WriteLine("Hello World!");
            //Задание 1
            double DoubleType = 125.234;
            string StringType = "Coaxil";
            int IntType = 2;
            object boxing = IntType;
            int unboxing = (int)boxing;


            //Задание 2
            Console.WriteLine("Task number 2");
            int MyNumber = 3;
            char MyNumberChar = Convert.ToChar(MyNumber);
            string MyNumberString = Convert.ToString(MyNumber);
            double MyNumberDouble = MyNumber / 2;


            //Задание 3
            Console.WriteLine("Task number 3");
            string MyName = "Pavel";
            Console.WriteLine(string.Format("My name is {0}", MyName));
            Console.WriteLine($"My name is {MyName}");


            //Задание 4
            Console.WriteLine("Task number 4");
            Console.WriteLine(DoubleType.GetType());
            Console.WriteLine(IntType.Equals(MyNumber));
            Console.WriteLine(StringType.GetHashCode());
            Console.WriteLine(String.IsNullOrEmpty(StringType));


            //Задание 5
            Console.WriteLine("Task number 5");
            string StringVariableOne = "String Number One";
            string StringVariableTwo = "String Number One";
            Console.WriteLine(String.Compare(StringVariableOne, StringVariableTwo)); // Сравнение строк
            Console.WriteLine(StringVariableOne.Contains(StringVariableTwo)); // Поиск Подстроки
            Console.WriteLine(StringVariableOne.Substring(4)); // Получение подстроки начиная с символа(4) и до конца строки 
            Console.WriteLine(StringVariableOne.Insert(7, StringVariableTwo)); // Вставка начиная с символа(7)
            Console.WriteLine(StringVariableOne.Replace(StringVariableOne, StringVariableTwo)); //Замена строк


            //Задание 6
            Console.WriteLine("Task number 6");
            string emptyString = "";
            string nullstring = null;
            Console.WriteLine(String.IsNullOrEmpty(emptyString));
            Console.WriteLine(String.IsNullOrEmpty(nullstring));


            //Задание 7
            Console.WriteLine("Task number 7");
            var variable = "";
            //variable = 5;


            //Задание 8 
            Console.WriteLine("Task number 8");
            int? ZERO = null;

            if (ZERO == null)
                Console.WriteLine("null");

            //Задание Medium Level
            Console.WriteLine("Task Medium Level");
            (int, int) tupleOne = (2, 2);
            TupleFunc(tupleOne); // передача в функцию кортежа из 2 элементов

            //Задание 2 
            (int nameOne,int nameTwo, string nameThree) tupleTwo = (nameOne : 7, nameTwo : 12, nameThree : "Pavel"); //поименнованный кортеж 
            Console.Write($"My age {tupleTwo.nameOne + tupleTwo.nameTwo}! "); // по имени 
            Console.WriteLine($"My name {tupleTwo.Item3}!"); // по полю 
            var (variableOne, variableTwo, variableThree) = tupleTwo; // распаковка кортежа 
            int _ = 5;

            //Задание 3
            FuncCheck();
            FuncUncheck();

            //Задание High Level
            using (Lab2Task3 newVariable = new Lab2Task3(2500))
            {
                Console.WriteLine(newVariable.AddedMoney());
            }
        }
    }
}
