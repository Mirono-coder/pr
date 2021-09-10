using System;
using System.IO;


namespace экзам
{
    class Program
    {
        public void pr()
        {
            StreamWriter se = new StreamWriter(@"\\main\RDP\44П\МироновДС\Desktop\Новая папка\экзам.txt");
            // Размерность массива
            Console.WriteLine("Введите число строк");
            int E = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int R = Convert.ToInt32(Console.ReadLine());
            se.WriteLine("Размер таблицы {0} > {1}", E, R);
            Console.Clear();

            
            int[,] Mas = new int[E, R];
            Console.WriteLine("введите число ограниченное 3 числами \n");
            se.WriteLine("Исходное число \n");
            for (int i = 0; i < E; i++)
            {
                Console.WriteLine("Видите числа из строки", i + 1);
                for (int j = 0; j < R; j++)
                {
                    Console.WriteLine("Введите {0} число", i + 1);
                    Mas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();

            
            int count = 0, cislo; int x1, x2, x3;
            int[] rMas = new int[E * R];
            se.WriteLine("Проверка");
            for (int i = 0; i < E; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    x1 = Mas[i, j] / 100;
                    x2 = Mas[i, j] % 100 / 10;
                    x3 = Mas[i, j] % 10;
                    cislo = (int)Math.Pow(x1, 3) + (int)Math.Pow(x2, 3) + (int)Math.Pow(x3, 3);
                    if (cislo == Mas[i, j])
                    {
                        rMas[count] = Mas[i, j];
                        count = count + 1;
                    }
                }
            }

            se.WriteLine("Завершено");

            
            Console.WriteLine("Начальное значение \n");
            for (int i = 0; i < E; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    Console.Write("{0:d3}", Mas[i, j]);
                    se.Write("{0:d3}", Mas[i, j]);
                }
                Console.WriteLine();
                se.WriteLine();
            }

            Console.WriteLine("Числа решения \n");
            se.WriteLine("Числа решения \n");
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0:d3}", rMas[i]);
                se.Write("{0:d3}", rMas[i]);
            }
            Console.WriteLine("Кол-во чисел решения равно {0} \n", count);
            se.WriteLine("Кол-во чисел решения равно {0} \n", count);
            se.Close();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.pr();
            Console.ReadKey();

        }
    }
}

