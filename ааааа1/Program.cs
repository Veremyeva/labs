using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ааааа1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Типы
            // 1а-инициализация типов
            Console.WriteLine("Первое задание");
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

            Console.WriteLine($"{no},{yes},{s},{l},{k},{c},{d},{f},{i},{h},{kol},{ul},{dul}");


            Console.WriteLine("пример приобразования и изучение возможностей convert");
            byte biti = Convert.ToByte(Console.ReadLine());
            char ch = Convert.ToChar(biti);
            Console.WriteLine(ch);

            Console.WriteLine("Запись строки");
            string p = Console.ReadLine();
            Console.WriteLine($"Привет, я {p}");  


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

            int h1 = 5;
            float h11 = h1;//неявн

            int h2 = 10;
            long h22 = h2; //неявн

            short h3 = 102;
            int h33 = h3; // неявн

            ushort h4 = 1;
            int h44 = h4; //неявн

            uint h5 = 11;
            long h55 = h5; //неявн
            
            int a1 = 22;
            object o = a1;   //  boxing
            int a2 = (int)o;  // unboxing
            Console.WriteLine();

            //работа с неявно типизированной переменной
            Console.WriteLine("работа с неявно типизированной переменной");
            var a3 = 2.3F;
            float kvadrat = a3 * a3;
            Console.WriteLine($" переменаня a3 в квадрате = {kvadrat}");
            Console.WriteLine();

            Console.WriteLine("Nullable");
            string a4 = null;
            int? a5 = null;
            Console.WriteLine($" string (cсылочный тип) = {a4} (тут null)" );
            Console.WriteLine($" int? (значимый тип) = {a5} (тут null)");
            Console.WriteLine();

            Console.WriteLine("задание f");
            var a6 = 16.3;
            a6 = 15;
            Console.WriteLine(a6);
            /*так как string ссылочный тип данных то ошибка будет 
            var a7 = "стринг";
            a7 = 15;*/
            Console.WriteLine();

            Console.WriteLine("2 - задание a");
            string l1 = "sosiska";
            string l2 = "sirok";
            int result = String.Compare(l1, l2);
            Console.WriteLine(result);
            Console.WriteLine();


            Console.WriteLine("2 - задание b");
            string l3 = "apple";
            string l4 = "banana";
            string l5 = "Haggy Waggy";
           
            string rContact = String.Concat(l3, l4, l5);
            Console.WriteLine(rContact);
            string rCopy = String.Copy(l3);
            Console.WriteLine(rCopy);
            string rSubstring = l4.Substring(2, 2);
            Console.WriteLine(rSubstring);
            string[] rSplit = l5.Split(' ');
            Console.WriteLine("Количество слов в строке: " + rSplit.Length);
            for (int w = 0; w < rSplit.Length; w++)
            {
                Console.Write(rSplit[w]);
                Console.Write("$");
            }
            Console.WriteLine();
            string s3 = l5.Insert(5, "y you ");
            Console.WriteLine(s3);
            string s33 = s3.Remove(6, 5);
            Console.WriteLine(s33);
            Console.WriteLine();

           
            //метод string.IsNullOrEmpty();
            //Указывает, действительно ли указанная строка является строкой null или пустой строкой ("")
            Console.WriteLine("2 - задание c");
            string с1 = "";
            string n1 = null;
            Console.WriteLine(String.IsNullOrEmpty(с1));
            Console.WriteLine(String.IsNullOrEmpty(n1));

            string nullik = null;
            string s4 = "Kissy Missy";
            bool booblik1 = String.IsNullOrEmpty(nullik);
            bool boobkik2 = String.IsNullOrEmpty(s4);
            Console.WriteLine($" они {booblik1}, {boobkik2} вот такие");
            Console.WriteLine();

            // Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.
            Console.WriteLine("2 - задание d");
            StringBuilder sb = new StringBuilder("OPA", 50);
            Console.WriteLine(sb);
            // Удалить P
            sb.Remove(1, 1);
            Console.WriteLine(sb);
            // Удалить A
            sb.Remove(1, 1);
            Console.WriteLine(sb);
            // Добавить П в конец
            sb.Append('П');
            Console.WriteLine(sb);
            // Добавить O в начало
            sb.Insert(0, 'О');
            Console.WriteLine(sb);
            Console.WriteLine();

            //массивы
            //3a
            Console.WriteLine("3 - задание a");
            int[,] myArray = { { 6, 0, 6 }, { 0, 6, 0 } };
            int rows = myArray.GetUpperBound(0) + 1; // количество строк
            int columns = myArray.Length / rows;
            for (int q = 0; q < rows; q++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[q, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("3 - задание b");
            int[] oneArray = new int[] { 0, 1, 2, 3, 4, 5 };
            for (int r = 0; r < oneArray.Length; r++)
            {
                Console.Write(oneArray[r] + " ");
            }
            Console.WriteLine();
            int aLevgth = oneArray.Length;
            Console.WriteLine("Длина массива: " + aLevgth);

            int[] twoA = new int[] { 5, 6, 1, 3, 4, 2 };
            for (int y = 0; y < oneArray.Length; y++)
            {
                Console.Write(twoA[y] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите номер элемента массива:");
            int element = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер места для перемещения элемента массива:");
            int place = Convert.ToInt32(Console.ReadLine());
            int kk = twoA[element - 1];
            twoA[element - 1] = twoA[place - 1];
            twoA[place - 1] = kk;
            for (int t = 0; t < oneArray.Length; t++)
            {
                Console.Write(twoA[t] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("3c");
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
            for (int ii = 0; ii < 2; ii++)
            {
                Console.Write("Введите элемент 1-ой строки:");
                int elementt = Convert.ToInt32(Console.ReadLine());

                myArr[0][ii] = element;
            }
            for (int ii = 0; ii < 3; ii++)
            {
                Console.Write("Введите элемент 2-ой строки:");
                int elementt = Convert.ToInt32(Console.ReadLine());

                myArr[1][ii] = element;
            }
            for (int ii = 0; ii < 4; ii++)
            {
                Console.Write("Введите элемент 3-ой строки:");
                int elementtt = Convert.ToInt32(Console.ReadLine());

                myArr[2][ii] = element;
            }
            Console.WriteLine();

            for (int t = 0; t < 2; t++)
            {
                Console.Write("{0}\t", myArr[0][t]);
            }
            Console.WriteLine();
            for (int t = 0; t < 3; t++)
            {
                Console.Write("{0}\t", myArr[1][t]);
            }
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {

                Console.Write("{0}\t", myArr[2][j]);
            }
            Console.WriteLine();

            //кортежи
            //4a
            Console.WriteLine("4 - задание a");
            (int, string, char, string, ulong) elem = (1, "что-то", 'e', "опять что-то", 7934076125);
            Console.WriteLine(elem);
            Console.WriteLine();
            //4b
            Console.WriteLine("4 - задание b");
            Console.WriteLine(elem.Item1.ToString() + " " + elem.Item3.ToString() + " " + elem.Item4);
            Console.WriteLine();

            //4c
            Console.WriteLine("4 - задание c");
            var (name, age) = ("Мудрое дерево", 25);
            Console.WriteLine($" {name}  {age} лет");  
            Console.WriteLine();

            //4d
            Console.WriteLine("4d-Распакковка кортежей");
            string oh = "строчечкаа";
            string oh2 = "строкаа";
            (oh, oh2) = (oh2, oh);
            Console.WriteLine(oh);
            Console.WriteLine(oh2);
            var _ = "чето";
            Console.WriteLine(_);
            Console.WriteLine();

            Console.WriteLine("4c-Сравните два кортежа");
            var t1 = (666, 777);
            var t2 = (222, 222);
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2); 
            // != - не равно
            Console.WriteLine();

            Console.WriteLine("5 - checked unchecked");
            byte happiness = 254;
            byte increasing_happiness = 2;


            happiness = (byte)(happiness + increasing_happiness);
            /*
            happiness = checked ((byte)(happiness + increasing_happiness)); 

            или 

            checked
            {   
            happiness = (byte)(happiness + increasing_happiness);
            }

            c unchecked аналогично
            
            happiness = unchecked ((byte)(happiness + increasing_happiness));*/
            Console.WriteLine($"Lvl of happiness = {happiness}");
        }
    }    
}