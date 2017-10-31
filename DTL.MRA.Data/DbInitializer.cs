using System;
using System.Linq;
using DTL.MRA.Data.Domains;

namespace DTL.MRA.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MraDbContext context)
        {

            context.Database.EnsureCreated();

            if (context.Customers.Any())
            {
                foreach(Customer customer in context.Customers){
                    context.Customers.Remove(customer);
                }
                context.SaveChanges();
            }

            var customers = new Customer[]
            {
                new Customer{FirstName="Carson",LastName="Alexander",Address="1 Lambton Quay, Wellington, New Zealand",PhoneNumber="(04) 444 1111"},
                new Customer{FirstName="Meredith",LastName="Alonso",Address="2 Lambton Quay, Wellington, New Zealand",PhoneNumber="(04) 444 2222"},
                new Customer{FirstName="Arturo",LastName="Anand",Address="3 Lambton Quay, Wellington, New Zealand",PhoneNumber="(04) 444 3333"},
                new Customer{FirstName="Gytis",LastName="Barzdukas",Address="4 Lambton Quay, Wellington, New Zealand",PhoneNumber="(04) 444 4444"},
                new Customer{FirstName="Yan",LastName="Li",Address="5 Lambton Quay, Wellington, New Zealand",PhoneNumber="(04) 444 5555"},
                new Customer{FirstName="Peggy",LastName="Justice",Address="6 Lambton Quay, Wellington, New Zealand",PhoneNumber="(04) 444 6666"},
                new Customer{FirstName="Laura",LastName="Norman",Address="7 Lambton Quay, Wellington, New Zealand",PhoneNumber="(04) 444 7777"},
                new Customer{FirstName="Nino",LastName="Olivetto",Address="8 Lambton Quay, Wellington, New Zealand",PhoneNumber="(04) 444 8888"}

            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }

            context.SaveChanges();
        }
    }
}
