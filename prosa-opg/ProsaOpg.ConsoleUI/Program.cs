using ProsaOpg.Data;

class Program
{
    static void Main(string[] args)
    {
#if DEBUG
        System.Console.WriteLine("Hello, World! - debug");
        IDataAccess dataAccess = DataAccessFactory.CreateDataContext("");
#else
        System.Console.WriteLine("Hello, World! - release");
        IDataAccess dataAccess = DataAccessFactory.CreateDataContext("Data Source=customers.db");
#endif
        var customers = dataAccess.GetAllCustomers();
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Name); // or .ToString()
        }
    }
}

