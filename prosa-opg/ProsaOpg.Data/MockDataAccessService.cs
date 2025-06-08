using ProsaOpg.Types;

namespace ProsaOpg.Data;

public class MockDataAccessService : IDataAccess
{
    public IEnumerable<Customer> GetAllCustomers()
    {
        List<Customer> customers = new List<Customer>();
        for (int i = 1; i <= 5; i++)
        {
            customers.Add(new Customer
            {
                Name = "Customer " + i,
                Id = i,
                Age = 20 + i,
                Country = "Country " + i,
                Revenue = 1000 + (i * 100),
                CreatedDate = DateTime.Now.AddDays(-i),
                IsActive = i % 2 == 0,
                Tags = new List<string> { "Tag1", "Tag2" }
            });

        }

        return customers;
    }
}