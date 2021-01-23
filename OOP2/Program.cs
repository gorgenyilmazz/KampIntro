using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demirog
            Individual customer1 = new Individual();
            customer1.CustomerId = 1;
            customer1.CustomerNo = "12345";
            customer1.CustomerName = "Engin";
            customer1.CustomerLastName = "Demirog";
            customer1.TcNo = "123456778";


            //TUZEL MUSTERI

            Corporate customer2 = new Corporate();
            customer2.CustomerId = 2;
            customer2.CustomerNo = "5668";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "345346675";

            //SOLID (L HARFI BIRBIRINE BENZIYOR DIYE INHERITANCE YAPMA)

            //new gordugun yerde 'bellekteki referans no' olarak oku
            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
