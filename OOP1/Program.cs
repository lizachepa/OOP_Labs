using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main()
        {

            //1
            int number = -100;//просто целые
            Console.WriteLine("Переменная: " + number + " .");
            uint a = 1;//только положительные
            Console.WriteLine("Переменная: " + a + " .");
            byte b = 255;//не более 256,знаимет меньше памяти,чем на инт
            Console.WriteLine("Переменная: " + b + " .");
            sbyte f = 45;
            Console.WriteLine("Переменная: " + f + " .");
            short d = 32650;//больше байта,но всё ещё маленький
            Console.WriteLine("Переменная: " + d + " .");
            ushort l = 3500;
            Console.WriteLine("Переменная: " + l + " .");
            float n = 4.2343653544f;
            Console.WriteLine("Переменная: " + n + " .");
            long ret = 48233847525730495;//самые длинные
            Console.WriteLine("Переменная: " + ret + " .");
            ulong k = 3265450;
            Console.WriteLine("Переменная: " + k + " .");
            double doub = 4579697094.30981948357973d;//огромные числа
            Console.WriteLine("Переменная:  " + doub + " .");
            decimal g = 3238467309650;
            Console.WriteLine("Переменная: " + g + " .");
            string word = "Переменная";//строка
            Console.WriteLine(word + doub + " .");
            char symbol = 'D';
            Console.WriteLine(word + " " + symbol + " .");
            bool happy = true;

            Int32 i32 = 5;
            Int64 i64 = i32;
            Single s = i32;//неявное приведение
            int num = 2147483647;
            long bigNum = num;//неявное
            byte cer = 4;             
            ushort z = cer;
            int p = 93488;
            int v = 3280945;
            long q = p;
            long lea = (long)(p + v);//Явное
            double op = 4.0;
            decimal pop = (decimal)op;//Явное
            short hop = 8768;//Явное
            int int2 = (int)hop;
            double zs = 32.7;//Явное с использованием класса Convert
            int int3 = Convert.ToInt32(zs);
            int val = 5;

            object obj = val;     // присваивание сопровождается упаковкой
            int valUnboxed = (int)obj; // приведение вызовет распаковку

            var kl = 34.6;//неявная типизация
            Console.WriteLine("Переменная: " + kl + " .");

            int? tr = null;//Nullable переменая
            Console.WriteLine(tr == null);

            //var kn = 4;
            //kn = 3F;//пропущено приведение типов
            //Console.WriteLine($"{kn}");

            //2
            //cравнение
            string str1 = "Liza";
            string str2 = "Chepeleva";
            int res = String.Compare(str1, str2);
            if (res == 0)
                Console.WriteLine($"Строка {str1} = {str2}");
            else
                Console.WriteLine($"Строка {str1} != {str2}");

            //
            String st1 = " Листья жёлтые ";
            String st2 = " Листья зелёные ";
            String st3;
            String st4 = " Красные листья ";

            Console.WriteLine(st1 + st2); //Конкатенация
            st3 = st2;                    //Копирование
            Console.WriteLine(st2.Substring(1, 2)); //Подстрока
            string[] words = st4.Split(new char[] { ' ' });//Разделение на слова 
            foreach (string h in words) Console.WriteLine(h);
            st1 = st1.Substring(0, 2) + st2 + st1.Remove(0, 2);
            Console.WriteLine(st1);
            st4 = st4.Remove(4, 6);//удаление

            Console.WriteLine("\n");
            double fg= 3;
            double ng = 4;
            Console.WriteLine($" Площадь треугольника со сторонами {fg} и {ng} равен {0.5 * fg * ng}\n");//интерполированная строка

            //
            string strr = "";
            string sttr = null;
            if (String.IsNullOrEmpty(strr))
                Console.WriteLine("Строка пустая или null\n");
            else
                Console.WriteLine("Строка не null или не пустая\n");


            // 
            StringBuilder sb = new StringBuilder(" пьет она ");
            sb.Remove(6, 3);//удаляет определенное количество символов, начиная с определенного индекса
            sb.Insert(0, "Петя");// вставляет подстроку в объект StringBuilder, начиная с определенного индекса
            sb.Append(" колу ");//добавление подстроки
            Console.WriteLine(sb+"\n");

            //3 
            //
            int t = 4,m = 3;
            int[,] nums = new int[t, m];
            Random rn = new Random();
            for (int y = 0; y < t; y++)
                for (int w = 0; w < m; w++)
                    nums[y, w] = rn.Next(12);
            for (int y = 0; y < t; y++)
            {
                for (int w = 0; w < m; w++)
                    Console.Write(String.Format("{0,3}", nums[y, w]));
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            //
            string[] wordss = new string[] { "Pop", "Leha", "Top" };
            words[1] = "Tommy";
            for (byte e = 0; e < 3; e++)
            {

                Console.WriteLine("El: " + wordss[e]);
            }
            Console.WriteLine("\n");
            //
            int i = 0;
            // Объявляем ступенчатый массив
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];

            // Инициализируем ступенчатый массив
            for (; i < 2; i++)
            {
                myArr[0][i] = i;
                Console.Write("{0}\t", myArr[0][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                myArr[1][i] = i;
                Console.Write("{0}\t", myArr[1][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 4; i++)
            {
                myArr[2][i] = i;
                Console.Write("{0}\t", myArr[2][i]);
            }
            Console.WriteLine("  \n");

            //неявно типизированный массив
            var A = new[] { 5, 10, 23, 16, 8 };

            //4 кортежи
            (int course, string name, string university, char mark, ulong age) = (2, "LizaChepeleva", "BSTU", 'A', 18);//создание кортежа

            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);

            (var lastname, var count) = ("Chepeleva", 7898);
            Console.WriteLine($"{lastname} {count}");//распаковка кортежа в переменные
           

            (int k, byte l) Yes = (5, 12);//сравнение
            (long z, uint d) No = (5, 12);
            if (Yes==No)
                Console.WriteLine("Равны\n");
            else
                Console.WriteLine("Не равны\n");

            //5
            void function(int[] mas, string hj)
            {
                int max, min, sum;
                char first;
                max = mas.Max<int>();
                min = mas.Min<int>();
                sum = mas.Sum();
                first = hj[0];
                Console.WriteLine(max+" max el ");
                Console.WriteLine(min + " min el ");
                Console.WriteLine(sum + " sum el ");
                Console.WriteLine(first + " first el ");
            }
            string sstr = "World";
            int[] mass = { 1, 2, 3, 4, 5 };
            function(mass, sstr);

            //6
            void function1()
            {
                checked
                {
                    int rat = 2147483647;
                    Console.WriteLine(rat + 1);
                }
            }
            void function2()
            {
                unchecked
                {
                    int cat = 2147483647;
                    Console.WriteLine(cat + 1);
                }
            }
            Console.Read();
            //function1();
            //function2();

        }
    }
}
