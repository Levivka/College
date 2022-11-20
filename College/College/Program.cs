using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.ExceptionServices;

Console.WriteLine("Введите номер работы с которой будем работать: \n 1 - Типы данных в c# \n 2 - Сортировка пузырьком и линейный поиск \n 3 - Нахождение n-ого числа Фибоначи \n 4 - Нахождение сумм арифмитической и геометрической прогрессий \n 5 - Нахождение общего делителя \n 6 - Перевод из десятичной системы счисчления в двоичную");
int work = Convert.ToInt32(Console.ReadLine());
switch (work)
{
    case 1:
        
        TypesCsharp();
        break;
    case 2:
        Fibonachi();
        break;
    case 3:
        Sorting();
        break;
    case 4:
        Progressia();
        break;
    case 5:
        NOD();
        break;
    case 6:
        Perevod();
        break;
    case 7:
        BinarniyPoisk();
        break;
}
static void TypesCsharp() {
    // типы значений в C#
    Console.WriteLine("Целочисленные значения: \n Тип: byte Минимальное значение: 0  Максимальное значение: 255 Размер данных: 1 байт");
    Console.WriteLine("Тип: sbyte Минимальное значение: -128  Максимальное значение: 127 Размер данных: 1 байт");
    Console.WriteLine("Тип: short Минимальное значение: -32768  Максимальное значение: 32767 Размер данных: 2 байта");
    Console.WriteLine("Тип: ushort Минимальное значение: 0  Максимальное значение: 65535 Размер данных: 2 байта");
    Console.WriteLine("Тип: int Минимальное значение: -2147483648  Максимальное значение: 2147483647 Размер данных: 4 байта");
    Console.WriteLine("Тип: uint Минимальное значение: 0  Максимальное значение: 4294967295 Размер данных: 4 байта");
    Console.WriteLine("Тип: long Минимальное значение: –9223372036854775808  Максимальное значение: 9223372036854775807 Размер данных: 8 байт");
    Console.WriteLine("Тип: ulong Минимальное значение: 0  Максимальное значение:  18446744073709551615 Размер данных: 8 байт");
    Console.WriteLine("Далее у нас идут числа с плавающей точкой(Нажмите Enter для продолжения):");
    Console.ReadLine();
    Console.WriteLine("Тип: float Минимальное значение: -3,402283E+38  Максимальное значение: 3,402283E+38 Размер данных: 4 байта");
    Console.WriteLine("Тип: double Минимальное значение: -1,79769313486232E+308  Максимальное значение: 1,79769313486232E+308 Размер данных: 8 байт");
    Console.WriteLine("Тип: decimal Минимальное значение: -79228162514264337593543950335  Максимальное значение: 79228162514264337593543950335 Размер данных: 16 байт");
    Console.WriteLine("Логический тип:");
    Console.WriteLine("Тип: bool Минимальное значение:False(0) Максимальное значение: True(1) Размер данных: 1 байт");
    Console.WriteLine("А теперь символьные типы:");
    Console.ReadLine();
    Console.WriteLine("Тип: char Минимальное значение:   Максимальное значение: ? Размер данных: 2 байта");
    Console.WriteLine("Тип: string Минимальное значение: В зависимости от длины строки  Максимальное значение: В зависимости от длины строки Размер данных: В зависимости от длины строки");
    Console.WriteLine("Особые типы:");
    Console.WriteLine("Тип: object Размер данных: 4 байта на 32 разрядной системе и 8 байт на 64 разрядной");
}
static void Sorting()
{
    Console.WriteLine("Введите 5 значений для сортировки их пузырьком:");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    int d = Convert.ToInt32(Console.ReadLine());
    int e = Convert.ToInt32(Console.ReadLine());
    int[] arr = { a, b, c, d, e };
    int temp = 0;
    for (int write = 0; write < arr.Length; write++)
    {
        for (int sort = 0; sort < arr.Length - 1; sort++)
        {
            if (arr[sort] > arr[sort + 1])
            {
                temp = arr[sort + 1];
                arr[sort + 1] = arr[sort];
                arr[sort] = temp;
            }
        }
    }
    Console.WriteLine("Вот значения отсортированные методом пузырька:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " "); 
    }

        Console.ReadLine();

        Console.WriteLine("Введите 5 значений для массива:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());
        int c1 = Convert.ToInt32(Console.ReadLine());
        int d1 = Convert.ToInt32(Console.ReadLine());
        int e1 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = { a1, b1, c1, d1, e1 };
        Console.Write("Ввести элемент поиска:");
        int j = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Линейный поиск:");
        int k = -1;
        for (int h = 0; h < arr1.Length; h++)
        {
            if (arr1[h] == j)
            {
                k = h;
            };
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
    int Number = Convert.ToInt32(Console.ReadLine());
    switch (Number)
    {
        case < 1:
            Console.WriteLine("Такого числа нету в ряде Фибоначи");
            break;
        case > 48:
                Console.WriteLine("Программа не сможет вычислить данное число ряда Фибоначи");
            break;
        default:
            int FirstNumber = 1;
            int SecondNumber = 1;
            int SummaFib;
            int j = 3;
            while (j <= Number)
            {
                SummaFib = FirstNumber + SecondNumber;
                FirstNumber = SecondNumber;
                SecondNumber = SummaFib;
                j++;
            }
            Console.WriteLine("Под номером {0} в ряде Фибоначчи стоит число {1}", Number, FirstNumber);
            break;
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
            double sum = 0;


            if (q < 1)
            {
                sum = 0;
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
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель прогрессии:");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элементов прогрессии:");
            int n = Convert.ToInt32(Console.ReadLine());
            int subsum;
            int sum = 0;
            subsum = FirstNum;
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
static void NOD()
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
static void BinarniyPoisk()
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

