﻿using System;

namespace simplexMethod
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Предприятие изготавливает четыре вида изделий К1, К2, К3, К4,\nиспользуя для этого три группы станков А, Б, В." +
                "\nОпределить какое количество видов изделий К1, К2, К3, К4\n" +
                "надо запланировать, чтобы прибыль предприятия была максимальной.");
            Console.ResetColor();
            double[,] main = new double[0,0];
            double[] res = new double[0], dohod = new double[0];
            int n = 0, m = 0, otv = 0;
            Console.WriteLine("\n1. Пример из таблицы в документе\n2. Рандомный ввод значений\n3. Самостоятельный ввод значений");
            metka: Console.Write("Введите способ заполнения данных: ");
            while (true)
            {
                try
                {
                    otv = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Вам необходимо ввести число!\nПовторите ввод: ");
                }
            }  
            switch (otv)
            {
                case 1:
                    main = new double[,] { { 1, 2, 3, 2 }, { 1, 2, 3, 4 }, { 1, 3, 2, 2 } };
                    res = new double[] { 30, 20, 40 };
                    dohod = new double[] { 1, 2, 3, 4 };
                    break;
                case 2:
                    while (true)
                    {
                        try
                        {
                            int a = 0;
                            while (true)
                            {
                                Console.Write("Введите количество видов изделий: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    n = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Количество изделий априори не может быть отрицательным числом..");
                                }
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine($"Количество видов изделий - численное значение, а вы ввели..\nВведите еще раз!");
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            int a = 0;
                            while (true)
                            {
                                Console.Write("Введите колчество ресурсов: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    m = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Количество ресурсов априори не может быть отрицательным числом..");
                                }
                            }
                            
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Количество видов ресурсов тоже число, прямо как количество видов изделий..\nВам необходимо повторить ввод");
                        }
                    }

                    main = new double[m, n];
                    res = new double[m];
                    dohod = new double[n];

                    Random rnd = new Random();

                    for (int i = 0; i < main.GetLength(0); i++)
                    {
                        for (int j = 0; j < main.GetLength(1); j++)
                        {
                            main[i, j] = rnd.Next(0, 10);
                        }
                    }

                    for (int i = 0; i < res.Length; i++)
                    {
                        res[i] = rnd.Next(0, 10);
                    }

                    for (int i = 0; i < dohod.Length; i++)
                    {
                        dohod[i] = rnd.Next(1, 10);
                    }
                    break;
                case 3:
                    while (true)
                    {
                        try
                        {
                            int a = 0;
                            while (true)
                            {
                                Console.Write("Введите количество видов изделий: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    n = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Количество изделий априори не может быть отрицательным числом..");
                                }
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine($"Количество видов изделий - численное значение, а вы ввели..\nВведите еще раз!");
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            int a = 0;
                            while (true)
                            {
                                Console.Write("Введите колчество ресурсов: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    m = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Количество ресурсов априори не может быть отрицательным числом..");
                                }
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Количество видов ресурсов тоже число, прямо как количество видов изделий..\nВам необходимо повторить ввод");
                        }
                    }

                    main = new double[m, n];
                    res = new double[m];
                    dohod = new double[n];
                    double h = 0;

                    for (int i = 0; i < main.GetLength(0); i++)
                    {
                        for (int j = 0; j < main.GetLength(1); j++)
                        {
                            while (true)
                            {
                                try
                                {
                                    while (true)
                                    {
                                        Console.Write($"Введите сколько необходимо ресурса №{j + 1} на изготовление {i + 1} продукта: ");
                                        h = Convert.ToDouble(Console.ReadLine());
                                        if (h >= 0)
                                        {
                                            main[i, j] = h;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"То есть от производства {i + 1} продукта ресурс {j + 1} будет пополняться?\nБраво)\nПовторите ввод");
                                        }
                                    }
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Вам необходимо ввести число!\nНи букву, ни специальный символ, а число!\nПовторите ввод");
                                }
                            }
                        }
                    }

                    for (int i = 0; i < res.Length; i++)
                    {
                        while (true)
                        {
                            try
                            {
                                while (true)
                                {
                                    Console.Write($"Введите запас ресурса №{i + 1}: ");
                                    h = Convert.ToDouble(Console.ReadLine());
                                    if (h >= 0)
                                    {
                                        res[i] = h;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Одна из ситуаций, когда ресурс идет не от поставщика, а к поставщику\nПовторите ввод");
                                    }
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Необходимо ввести число!\nПовторите ввод");
                            }
                        }
                        
                    }

                    for (int i = 0; i < dohod.Length; i++)
                    {
                        while (true)
                        {
                            try
                            {
                                while (true)
                                {
                                    Console.Write($"Введите прибыль с реалзации продукта №{i + 1}: ");
                                    h = Convert.ToDouble(Console.ReadLine());
                                    if (h >= 0)
                                    {
                                        dohod[i] = h;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Прибыль должна быть больше нуля\nПовторите ввод");
                                    }
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Необходимо ввести число!\nПовторите ввод");
                            }
                        }
                        
                    }

                    break;
                default:
                    Console.WriteLine("Такого варианта нет..\nПовторите ввод");
                    goto metka;
            }
            
            int temp = main.GetLength(1) + 1, dop = temp;
            double[] ans = new double[0];
            Console.WriteLine("Математическая модель задачи:");
            Console.Write("\tF = ");
            for (int i = 0; i < dohod.Length; i++)
            {
                if(i != dohod.Length - 1)
                {
                    Console.Write($"{dohod[i]}x{i + 1} + ");
                }
                else
                {
                    Console.Write($"{dohod[i]}x{i + 1} -> max\n");
                }
            }
            for (int i = 0; i < main.GetLength(0); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < main.GetLength(1); j++)
                {
                    if (j != main.GetLength(1) - 1)
                    {
                        Console.Write($"{main[i, j]}x{j + 1} + ");
                    }
                    else
                    {
                        Console.Write($"{main[i, j]}x{j + 1} <= {res[i]}");
                    }
                }
                Console.WriteLine();
            }
            Console.Write($"\tx");
            for (int i = 0; i < main.GetLength(1); i++)
            {
                if(i != main.GetLength(1) - 1)
                {
                    Console.Write($"{i + 1},");
                }
                else
                {
                    Console.Write($"{i + 1}");
                }
            }
            Console.WriteLine($" >= 0\n");

            Console.WriteLine("Каноническая задача минимизации, составленная по условию задачи:");
            Console.Write("\tF' = -(");
            for (int i = 0; i < dohod.Length; i++)
            {
                if (i != dohod.Length - 1)
                {
                    Console.Write($"{dohod[i]}x{i + 1} + ");
                }
                else
                {
                    Console.Write($"{dohod[i]}x{i + 1}) -> min\n");
                }
            }
            for (int i = 0; i < main.GetLength(0); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < main.GetLength(1); j++)
                {
                    if (j != main.GetLength(1) - 1)
                    {
                        Console.Write($"{main[i, j]}x{j + 1} + ");
                    }
                    else
                    {
                        Console.Write($"{main[i, j]}x{j + 1} + x{temp++} = {res[i]}");
                    }
                }
                Console.WriteLine();
            }
            Console.Write($"\tx");
            for (int i = 0; i < main.GetLength(1); i++)
            {
                if(i == main.GetLength(1) - 1)
                {
                    Console.Write($"{i + 1}");
                }
                else
                {
                    Console.Write($"{i + 1},");
                }
            }
            Console.Write($" >= 0; x");
            while (dop != temp)
            {
                if (dop + 1 != temp)
                {
                    Console.Write($"{dop},");
                }
                else
                {
                    Console.Write($"{dop}");
                }
                dop++;
            }
            Console.WriteLine(" - любое\n");

            double[,] Table = new double[main.GetLength(0) + 1, main.GetLength(1) + main.GetLength(0) + 1];
            temp = main.GetLength(1);
            for (int i = 0; i < main.GetLength(0); i++)
            {
                for (int j = 0; j < main.GetLength(1); j++)
                {
                    if(j != main.GetLength(1) - 1)
                    {
                        Table[i, j] = main[i, j];
                    }
                    else
                    {
                        Table[i, j] = main[i, j];
                        Table[i, temp++] = 1;
                    }
                }
            }
            for (int i = 0; i < res.Length; i++)
            {
                Table[i, Table.GetLength(1) - 1] = res[i];
            }
            for (int i = 0; i < dohod.Length; i++)
            {
                Table[Table.GetLength(0) - 1, i] = dohod[i];
            }

            simplex.intermediate(Table, ref ans, 0);

            bool check = false;
            int col, row;
            int o = 0;
            while (true)
            {
                col = simplex.decisiveColumn(Table);
                row = simplex.decisiveRow(Table, col);

                Console.WriteLine($"Разрешающий столбец: {col + 1}");
                Console.WriteLine($"Разрешающая строка: {row + 1}");
                
                simplex.solve(ref Table, row, col);

                simplex.intermediate(Table, ref ans, o + 1);

                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    if(Table[Table.GetLength(0) - 1, j] > 0 && Table[Table.GetLength(0) - 1, j] != 0)
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    break;
                }
                o++;
            }
            simplex.finalResults(main.GetLength(1), ans, Table);
        }
    }

    class simplex
    {
        public static void finalResults(double r, double[] a, double[,] b)
        {
            Console.WriteLine("\nОкончательные результаты:");
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"x{i + 1} = {a[i]}");
            }
            Console.WriteLine($"F = {Math.Round(Math.Abs(b[b.GetLength(0) - 1, b.GetLength(1) - 1]), 3)}");
        }

        public static void solve(ref double[,] a, int row, int col)
        {
            double var = a[row, col];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[row, j] = (double)(a[row, j] / var);
            }
            double del;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                del = a[i, col];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i != row)
                    {
                        var = a[row, j];
                        var *= -del;
                        a[i, j] += var;
                    }
                }
            }
        }

        public static int decisiveRow(double[,]a, int b)
        {
            double[,] a1 = new double[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    a1[i, j] = Convert.ToDouble(a[i, j]);
                }
            }
            double min = double.MaxValue;
            int temp = 0;
            for (int i = 0; i < a1.GetLength(0) - 1; i++)
            {
                if(a1[i, a1.GetLength(1) - 1] != 0 && a1[i, b] > 0)
                {
                    if ((a1[i, a1.GetLength(1) - 1] / a1[i, b]) < min)
                    {
                        min = a1[i, a1.GetLength(1) - 1] / a1[i, b];
                        temp = i;
                    }
                }
            }
            return temp;
        }

        public static int decisiveColumn(double[,] a)
        {
            double max = double.MinValue;
            int temp = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if(a[a.GetLength(0) - 1, j] >= 0)
                {
                    if (a[a.GetLength(0) - 1, j] > max)
                    {
                        max = a[a.GetLength(0) - 1, j];
                        temp = j;
                    }
                }
            }
            return temp;
        }

        public static void show(double[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]:f3} ");
                }
                Console.WriteLine();
            }
        }

        public static void show(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        public static void intermediate(double[,] a, ref double[] b, int o)
        {
            Array.Resize(ref b, 0);
            if (o == 0)
            {
                Console.WriteLine($"\n1-ая симплекс-таблица:");
            }
            else
            {
                Console.WriteLine($"\n{o + 1}-я Симплекс-таблица:");
            }
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]:f3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nРезультаты таблицы:");
            int temp = 0, temp2 = 0;
            for (int j = 0; j < a.GetLength(1) - 1; j++)
            {
                temp = 0;
                temp2 = 0;
                for (int i = 0; i < a.GetLength(0) - 1; i++)
                {
                    if (a[i, j] == 0)
                        temp++;
                    if (a[i, j] == 1)
                        temp2++;
                }
                if (temp == a.GetLength(0) - 2 && temp2 == 1)
                {
                    for (int i = 0; i < a.GetLength(0) - 1; i++)
                    {
                        if (a[i, j] == 1)
                        {
                            temp = i;
                        }
                    }
                    Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = Math.Round(a[temp, a.GetLength(1) - 1]);
                }
                else
                {
                    Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = 0;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"x{i + 1} = {b[i]}");
            }
            Console.WriteLine($"F' = {Math.Round(a[a.GetLength(0) - 1, a.GetLength(1) - 1], 3)}");
            Console.WriteLine($"F = {Math.Round(Math.Abs(a[a.GetLength(0) - 1, a.GetLength(1) - 1]), 3)}");
        }
    }
}