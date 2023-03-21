// See https://aka.ms/new-console-template for more information

public class Penjumlahan
{
    public static void jumlahTigaAngka<T>(T num1, T num2, T num3)
    {
        Console.WriteLine((dynamic)num1 + num2 + num3);
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewDaat<T>(T data)
    {
        
        storedData.Add((dynamic)data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for(int i=0;i<storedData.Count;i++) {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu " + inputDates[i]);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan.jumlahTigaAngka<float>(13, 02, 21);
        SimpleDataBase<string> database = new SimpleDataBase<string>();
        database.addNewDaat("13");
        database.addNewDaat("02");
        database.addNewDaat("21");
        database.printAllData();

    }
}