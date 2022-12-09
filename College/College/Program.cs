using Npgsql;
Console.WriteLine("Введите номер работы с которой будем работать: \n 1 - Типы данных в c# \n 2 - Сортировка пузырьком и линейный поиск \n 3 - Нахождение n-ого числа Фибоначи \n 4 - Нахождение сумм арифмитической и геометрической прогрессий \n 5 - Нахождение общего делителя \n 6 - Перевод из десятичной системы счисчления в двоичную \n 7 - Тернарные операции для бинарного выбора \n 8 - Рассчитывание ДКТ для матрицы 8 порядка \n 9 - Карта звёздного неба");
int work = Convert.ToInt32(Console.ReadLine());
switch (work)
{
    case 1:
        
        TypesCsharp();
        break;
    case 2:
        Sorting();
        break;
    case 3:
        Fibonachi();
        break;
    case 4:
        Progressia();
        break;
    case 5:
        Nod();
        break;
    case 6:
        Perevod();
        break;
    case 7:
        TernarnieOp();
        break;
    case 8:
        Dkt();
        break;
    case 9:
        StarMap();
        break;
    case 10:
        BD();
        break;
}
static void TypesCsharp() {
    // типы значений в C#
    Console.WriteLine($"Целочисленные значения: \n Тип: byte Минимальное значение: {Byte.MinValue}  Максимальное значение: {Byte.MaxValue} Размер данных: 1 байт");
    Console.WriteLine($"Тип: sbyte Минимальное значение: {SByte.MinValue}  Максимальное значение: {SByte.MaxValue} Размер данных: 1 байт");
    Console.WriteLine($"Тип: short Минимальное значение: {short.MinValue}  Максимальное значение: {short.MaxValue} Размер данных: 2 байта");
    Console.WriteLine($"Тип: ushort Минимальное значение: {ushort.MinValue}  Максимальное значение: {short.MaxValue} Размер данных: 2 байта");
    Console.WriteLine($"Тип: int Минимальное значение: {int.MinValue}  Максимальное значение: {int.MaxValue} Размер данных: 4 байта");
    Console.WriteLine($"Тип: uint Минимальное значение: {uint.MinValue}  Максимальное значение: {uint.MaxValue} Размер данных: 4 байта");
    Console.WriteLine($"Тип: long Минимальное значение: {long.MinValue}  Максимальное значение: {long.MaxValue} Размер данных: 8 байт");
    Console.WriteLine($"Тип: ulong Минимальное значение: {ulong.MinValue}  Максимальное значение:  {ulong.MaxValue} Размер данных: 8 байт");
    Console.WriteLine("Далее у нас идут числа с плавающей точкой(Нажмите Enter для продолжения):");
    Console.ReadLine();
    Console.WriteLine($"Тип: float Минимальное значение: {float.MinValue}  Максимальное значение: {float.MaxValue} Размер данных: 4 байта");
    Console.WriteLine($"Тип: double Минимальное значение: {double.MinValue}  Максимальное значение: {double.MaxValue} Размер данных: 8 байт");
    Console.WriteLine($"Тип: decimal Минимальное значение: {decimal.MinValue}  Максимальное значение: {decimal.MaxValue} Размер данных: 16 байт");
    Console.WriteLine("Логический тип:");
    Console.WriteLine("Тип: bool Минимальное значение:False(0) Максимальное значение: True(1) Размер данных: 1 байт");
    Console.WriteLine("А теперь символьные типы:");
    Console.ReadLine();
    Console.WriteLine($"Тип: char Минимальное значение: {char.MinValue} Максимальное значение: {char.MaxValue} Размер данных: 2 байта");
    Console.WriteLine("Тип: string Минимальное значение: В зависимости от длины строки  Максимальное значение: В зависимости от длины строки Размер данных: В зависимости от длины строки");
    Console.WriteLine("Особые типы:");
    Console.WriteLine("Тип: object Размер данных: 4 байта на 32 разрядной системе и 8 байт на 64 разрядной");
}
static void Sorting()
{
    Console.WriteLine("Введите размер массива для сортировки значений из них методом пузырька:");
    int ammount = Convert.ToInt32(Console.ReadLine());  //динамический массив (n), где n и y вводятся с консоли (Console.ReadLine()) и заполняется через класс Random (rand.Next()) \/
    int[] array = new int[ammount];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(0, 50);
    Console.WriteLine("Выведем наш массив на экран:");
    var str = string.Join(" ", array);
    Console.WriteLine(str);

    int temp;
    for (int write = 0; write < array.Length; write++)
    {
        for (int sort = 0; sort < array.Length - 1; sort++)
        {
            if (array[sort] > array[sort + 1])
            {
                temp = array[sort + 1];
                array[sort + 1] = array[sort];
                array[sort] = temp;
            }
        }
    }
    Console.WriteLine("Вот значения отсортированные методом пузырька:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }

        Console.ReadLine();

        Console.WriteLine("Введите размер массива для сортировки значений из них методом пузырька:");
        int ammount1 = Convert.ToInt32(Console.ReadLine());  //динамический массив (n), где n и y вводятся с консоли (Console.ReadLine()) и заполняется через класс Random (rand.Next()) \/
        int[] arr1 = new int[ammount1];
        Random rand1 = new Random();
        for (int i = 0; i < arr1.Length; i++)
            arr1[i] = rand1.Next(0, 50);
        Console.WriteLine("Выведем наш массив на экран:");
        var str1 = string.Join(" ", arr1);
        Console.WriteLine(str1);
        //динамический массив (n), где n и y вводятся с консоли (Console.ReadLine()) и заполняется через класс Random (rand.Next()) \/
        Console.Write("Ввести элемент поиска:");
        int j = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Линейный поиск:");
        int k = -1;
        for (int h = 0; h < arr1.Length; h++)
        {
            if (arr1[h] == j)
            {
                k = h + 1;
            }
        }
        if (k > -1)
        {
            Console.WriteLine("Номер элемента = {0}", k);
        }

    }
static void Fibonachi()
{
    Console.WriteLine("Нахождение N-ого числа фибоначи:");
    Console.WriteLine("Введите номер элемента который вы хотите найти среди чисел фибоначи");
    int number = Convert.ToInt32(Console.ReadLine());
    // заменить свитч на if \/
    if (number <= 1)
    {
        Console.WriteLine("Такого числа нету в ряде Фибоначи");

    }
    else if (number >= 48)
    {
        Console.WriteLine("Программа не сможет вычислить данное число ряда Фибоначи");
    }
    else
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int j = 2;
        while (j <= number)
        {
            var summaFib = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = summaFib;
            j++;
        }

        Console.WriteLine("Под номером {0} в ряде Фибоначчи стоит число {1}", number, firstNumber);
    }
}
static void Progressia()
{
    Console.WriteLine("Выберите с какой прогрессией будем работать:\n 1 - Арифметическая \n 2 - Геометрическая");
    int progressia = Convert.ToInt32(Console.ReadLine());
    if (progressia == 1)
    {
        Console.WriteLine("С помощью чего будем решать? \n 1 - Цикл \n 2 - Формула");
        int vibor = Convert.ToInt32(Console.ReadLine());
        if (vibor == 1)
        {
            int a;
            int step;
            int n;
            int sum = 0;
            int subSum;
            Console.WriteLine("Введите первый элемент");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель прогрессии");
            step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число элементов");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                subSum = a;
                subSum += step;
                sum += subSum;
            }
            Console.WriteLine("Сумма членов прогрессии равна {0}",sum);
            Console.ReadLine();
        }
       else if (vibor == 2)
        
        {
            int a1;
            int step1;
            int n1;
            int sum1 = 0;
            Console.WriteLine("Введите первый элемент");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель прогрессии");
            step1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число элементов");
            n1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                sum1 += a1 + (i - 1) * step1;
            }
            Console.WriteLine("Сумма членов прогрессии равна " + Convert.ToString(sum1));
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Ошибка, такого пункта не существует 0_o");
        }
    }
    else if (progressia == 2)
    {
        Console.WriteLine("С помощью чего будем решать? \n 1 - Формула \n 2 - Цикл");
        int vibor1 = Convert.ToInt32(Console.ReadLine());
        if (vibor1 == 1)
        {
            Console.WriteLine("Введите первое число прогрессии:");
            double a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель прогрессии:");
            double q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            int h = n;
            double sum;


            if (q < 1)
            {
                sum = 0;
                Console.WriteLine("{0}", sum);
            }
            else
            {
                sum = (a1 * (Math.Pow(q, h) - 1)) / (q - 1);
                Console.WriteLine("Сумма геометрической прогрессии равна {0}", sum);
            }
        }
        if (vibor1 == 2)
        {
            Console.WriteLine("Введите первое значение прогрессии:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель прогрессии:");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элементов прогрессии:");
            int n = Convert.ToInt32(Console.ReadLine());
            int subsum;
            int sum = 0;
            subsum = firstNum;
            sum += subsum;
            for (int i = 1; i < n; i++)
            { 
                subsum *= q;
                sum += subsum;
            }
            Console.WriteLine("Сумма геометрической прогрессии равна {0}", sum);
        }
        else
        {
            Console.WriteLine("Ошибка, такого пункта не существует 0_o");
        }  
        
    }
    else
    {
        Console.WriteLine("Ошибка, такого пункта не существует 0_o");
    }
    
}
static void Nod()
{
    int nod;
    Console.WriteLine("Введите 2 числа у которых нужно будет найти наибольший общий делитель");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());

    while (m != n)
    {
        if (m > n)
        {
            m = m - n;
        }
        else
        {
            n = n - m;
        }
    }

    nod = n;
    Console.WriteLine("НОД данных чисел равен:{0} ", nod);

    Console.ReadKey();
}  
static void Perevod()
{
    Console.WriteLine("Введите число которое нужно преобразовать в двоичную систему счисления:");
    int x = Convert.ToInt32(Console.ReadLine());
    int x1 = x;
    void Perevod10(int x)
    {
        if (x >= 2)
        {
            Perevod10(x / 2);
            Console.Write(x % 2);
        }
        else
        {
            Console.Write("Число {0} в двоичной сиситеме счисления будет выглядеть так {1}", x1, x % 2);
        }
    }
        if (x >= 0)
        {
            Perevod10(x);
        }
        else
        {
            Console.WriteLine("Данное число невозможно преобразовать");
        }
        Console.ReadKey();


    
}
static void TernarnieOp()
{
        int[] myArray = new int[5];
        Random rand = new Random();
    int x = 0;
    int a = 0;
    int b = 0;
    int c = 0;
    int d = 0;
    int h = 0;
    for (int k = x; k < myArray.Length; k++)
        {
            myArray[x] = rand.Next(20);
            Console.WriteLine("Значение элемента массива {0} = {1}", k, myArray[x]);
        switch (k)
        {
            case 0:
                a = myArray[x];
                break;
            case 1:
                b = myArray[x];
                break;
            case 2:
                c = myArray[x];
                break;
            case 3:
                d = myArray[x];
                break;
            case 4:
                h = myArray[x];
                break;
        }
        }
    Console.WriteLine("Введите одно из чисел которое хотите найти: \n {0} \n {1} \n {2} \n {3} \n {4}",a,b,c,d,h);
    int error = 0;
    
    
        int number = Convert.ToInt32(Console.ReadLine());
        int output, output2, output3, output4, output5;
         output5 = number == h ? 5 : error = 1;
         output4 = number == d ? 4 : output5;
         output3 = number == c ? 3 : output4;
        output2 = number == b ? 2 : output3;
         output = number == a ? 1 : output2;
    if (error == 0)
        Console.WriteLine("Число {0} находится под номером {1}", number, output);
    
    else if (error == 1)
    {
        Console.WriteLine("Ошибка");
    }
}
static void Dkt()
{
    
        Console.WriteLine("Введите количество строк в нашей матрице:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в нашей матрице:");
        int colls = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Исходная матрица:");
        int[,] mas = new int[rows, colls];
        Random rnd = new Random();
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < colls; j++)
            {
                mas[i, j] = rnd.Next(0, 10);
                Console.Write(mas[i, j] + "\t");
        
            }

            Console.WriteLine();
    
    
        }
        Console.WriteLine();
        Console.WriteLine("Транспонированная матрица:");
        int[,] Transpose = new int[colls,rows];
        for (int i = 0; i < colls; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Transpose[i, j] = mas[j, i];
        
                Console.Write(Transpose[i, j] + "\t");
            }

            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("ДКТ матрицы 8 порядка:");
        //убрать массив и использовать i/j (просто инкременты цикла)
        double[,] massive =
        {
            { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 },
            { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }
        };
        //rows & colls всегда равны 8
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colls; j++)
            {
        
                if (j == 0) massive[i, j] = (1 / Math.Sqrt(8));
                if (j > 0) massive[i,j] = Math.Sqrt(0.25) * Math.Cos((2 * i + 1) * j * Math.PI / (2 * 8));
                Console.Write($"{massive[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
static void StarMap()
{
    int length = 24;int shirina = 180;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < shirina; j++)
        {
            if (i == 0 || i == (length - 1))
            {
                Console.Write("═");
            }
            else
            {
                if (j == 0 || j == (shirina - 1))
                {
                    Console.Write("║");
                }
                else
                {
                    
                    
                        Console.Write(" ");
                    
                }
            }
        }    Console.WriteLine();
    }
    // Треугольник 
Console.SetCursorPosition(20, 2); Console.Write("*");
Console.SetCursorPosition(25, 2); Console.Write("*");
Console.SetCursorPosition(22, 5); Console.Write("*");

// Большая медведица
Console.SetCursorPosition(113, 4); Console.Write("*");
Console.SetCursorPosition(115, 2); Console.Write("*");
Console.SetCursorPosition(125, 3); Console.Write("*");
Console.SetCursorPosition(124, 5); Console.Write("*");
Console.SetCursorPosition(128, 6); Console.Write("*");
Console.SetCursorPosition(130, 7); Console.Write("*");
Console.SetCursorPosition(134, 8); Console.Write("*");

//  Рак
Console.SetCursorPosition(45, 2); Console.Write("*");
Console.SetCursorPosition(47, 4); Console.Write("*");
Console.SetCursorPosition(46, 5); Console.Write("*");
Console.SetCursorPosition(42, 7); Console.Write("*");
Console.SetCursorPosition(55, 8); Console.Write("*");

// Щит
Console.SetCursorPosition(14, 9); Console.Write("*");
Console.SetCursorPosition(17, 12); Console.Write("*");
Console.SetCursorPosition(18, 13); Console.Write("*");
Console.SetCursorPosition(28, 16); Console.Write("*");
Console.SetCursorPosition(25, 12); Console.Write("*");


// Северная корона
Console.SetCursorPosition(70, 9); Console.Write("*");
Console.SetCursorPosition(77, 10); Console.Write("*");
Console.SetCursorPosition(82, 8); Console.Write("*");
Console.SetCursorPosition(81, 7); Console.Write("*");
Console.SetCursorPosition(78, 6); Console.Write("*");
Console.SetCursorPosition(74, 6); Console.Write("*");

// Хвост змеи
Console.SetCursorPosition(96, 9); Console.Write("*");
Console.SetCursorPosition(96, 11); Console.Write("*");
Console.SetCursorPosition(99, 10); Console.Write("*");
Console.SetCursorPosition(110, 11); Console.Write("*");
Console.SetCursorPosition(113, 14); Console.Write("*");

// Возничий
Console.SetCursorPosition(53, 16); Console.Write("*");
Console.SetCursorPosition(44, 18); Console.Write("*");
Console.SetCursorPosition(49, 19); Console.Write("*");
Console.SetCursorPosition(44, 19); Console.Write("*");
Console.SetCursorPosition(48, 17); Console.Write("*");
Console.SetCursorPosition(52, 18); Console.Write("*");

// Малая медведица
Console.SetCursorPosition(142, 13); Console.Write("*");
Console.SetCursorPosition(148, 14); Console.Write("*");
Console.SetCursorPosition(152, 15); Console.Write("*");
Console.SetCursorPosition(160, 14); Console.Write("*");
Console.SetCursorPosition(168, 13); Console.Write("*");
Console.SetCursorPosition(160, 16); Console.Write("*");
Console.SetCursorPosition(169, 15); Console.Write("*");
Console.ReadKey();
}

static void BD()
{
    string connString = "Host=localhost;Username=levik;Password=1234;Database=postgres";
    NpgsqlConnection con = new NpgsqlConnection(connString);NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM constellations", con);
    con.Open();
    Console.WriteLine("");
    NpgsqlDataReader reader = com.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"{reader[0]},{reader[1]},{reader[2]}, {reader[3]}, {reader[4]}, {reader[5]}");
    }con.Close();
}
Console.ReadKey();
