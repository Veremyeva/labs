using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace labachka1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Типы
            // 1а-инициализация типов
            Console.WriteLine("1a");
            bool no = false;
            bool yes = true;
            sbyte s = -100;// -128 to 127
            short l = 102;//-32768 to 32767
            ushort k = 1;//0 to 65535;
            char c = 's';
            double d = 25.7;
            float f = 1.14F;
            int i = 25;
            uint h = 11;
            long kol = -10;
            ulong ul = 12;
            decimal dul = 2.1m;
            Console.WriteLine(5 == 5);
            Console.WriteLine($"{no},{yes},{s},{l},{k},{c},{d},{f},{i},{h},{kol},{ul},{dul}");

            Console.Write("число типа float: ");
            string f1 = Console.ReadLine();
            Console.WriteLine($"Привет {f1}");
            Console.WriteLine();
            Console.WriteLine();
            // 1b-явное и не явное приведениеи типов
            Console.WriteLine("1b");
            int h1 = 5;
            float h11 = h1;//неявн

            int h2 = 10;
            long h22 = h2; //неявн

            short h3 = 102;
            int h33 = h3; // неявн

            ushort h4 = 1;
            int h44 = h4; //неявн

            uint h5 = 11;
            long h55 = h5;

            float h6 = 25.98F;
            int h66 = (int)h6;//явн

            double h7 = 12.3;
            int h77 = (int)h7;//явн

            short h8 = 102;
            ushort h88 = (ushort)h8;//явн

            int h9 = 10;
            uint h99 = (uint)h9; //явн

            float h10 = 5.6578F;
            int h1010 = (int)h10;//явн
            Console.WriteLine($"{h11},{h22},{h33},{h44},{h55},{h66},{h77},{h88},{h99},{h1010}");
            Console.WriteLine();
            Console.WriteLine();
            // 1c-упаковка и распаковка значимых типов
            Console.WriteLine("1c");
            int price = 39;
            Object obj = price;//выделяем место в куче(упаковка)
            Console.WriteLine(obj);

            int price2 = (int)obj;//распаковка
            Console.WriteLine(price2);
            Console.WriteLine();
            Console.WriteLine();
            //1d-работа с неявно типизированной переменной
            Console.WriteLine("1d");
            float h555 = 25.98F;
            int h666 = (int)h555;
            int kvadrat = h666 * h666;
            Console.WriteLine(kvadrat);
            Console.WriteLine();
            Console.WriteLine();
            //1e-Nullable
            Console.WriteLine("1e");
            //Nullable - фича которая позволяет присвоить значения null значимым типам данных(ссылочный тип может быть null / string str = null)
            int? numbe1 = null;
            int? number2 = 23;
            Console.WriteLine(numbe1 + "тут null");
            Console.WriteLine(number2);
            Console.WriteLine();
            Console.WriteLine();
            //1f
            Console.WriteLine("1f");
            var err1 = 16.3;
            err1 = 15;
            Console.WriteLine(err1);
            /*так как string ссылочный тип данных то ошибка будет
            var err1 = "hello";
            err1 = 15;*/
            Console.WriteLine();
            Console.WriteLine();



            //строки
            //2a
            Console.WriteLine("2a");
            string l1 = "Masha";
            string l2 = "Alex";
            int result = String.Compare(l1, l2);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();
            //2b
            Console.WriteLine("2b");
            string string1 = "red";
            string string2 = "green";
            string string3 = "blue we";
            string rContact = String.Concat(string1, string2, string3);
            Console.WriteLine(rContact);
            string rCopy = String.Copy(string1);
            Console.WriteLine(rCopy);
            string rSubstring = string2.Substring(2, 2);
            Console.WriteLine(rSubstring);
            string[] rSplit = string3.Split(' ');
            Console.WriteLine("Количество слов в строке: " + rSplit.Length);
            for (int w = 0; w < rSplit.Length; w++)
            {
                Console.Write(rSplit[w]);
                Console.Write("|");
            }
            Console.WriteLine();
            string s3 = string3.Insert(5, "you ");
            Console.WriteLine(s3);
            string s33 = s3.Remove(5, 4);
            Console.WriteLine(s33);
            Console.WriteLine();
            Console.WriteLine();
            //2c
            //метод string.IsNullOrEmpty.---");
            //Указывает, действительно ли указанная строка является строкой null или пустой строкой ("")
            Console.WriteLine("2c");
            string pString = "";
            string nString = null;
            Console.WriteLine(String.IsNullOrEmpty(pString));
            Console.WriteLine(String.IsNullOrEmpty(nString));

            string mynull = null;
            string str = "Trafalgar Law";
            bool abraka = String.IsNullOrEmpty(mynull);
            bool dabra = String.IsNullOrEmpty(str);
            Console.WriteLine($"{abraka}, {dabra}");
            Console.WriteLine();
            Console.WriteLine();
            //2d
            Console.WriteLine("2d");
            StringBuilder sb = new StringBuilder("ABC", 50);
            Console.WriteLine(sb);