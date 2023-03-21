// See https://aka.ms/new-console-template for more information

public class Penjumlahan
{
    public static void jumlahTigaAngka<T>(T num1, T num2, T num3)
    {
        Console.WriteLine((dynamic)num1 + num2 + num3);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan.jumlahTigaAngka<float>(13, 02, 21);
    }
}