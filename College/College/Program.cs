using System;
void TypesCsharp() {
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
void BitovieOperations()
{
    void metod1()
    {
        Console.WriteLine("Введите значения 3 переменных;");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = a * b * c;
        Console.WriteLine(d);
    }
}
Console.WriteLine("Введите номер работы с которой будем работать:");
int work = Convert.ToInt32(Console.ReadLine());
switch (work)
{
    case 1:
        TypesCsharp;
        break;
    case 2:
        object k = BitovieOperations;
        break;
    case 3:
        Console.WriteLine("Ваше имя - Sam");
        break;

}
