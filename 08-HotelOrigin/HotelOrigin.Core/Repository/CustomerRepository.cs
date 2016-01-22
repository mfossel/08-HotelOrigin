using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domain;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.IO;
namespace HotelOrigin.Core.Repository
{
    public class CustomerRepository
    {
         public static ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

        //Create Method

         public static Customer Create(int id, string firstName, string lastName, string email, string phoneNumber)
        {

          Customer customer = new Customer();
          customer.id = id;
          customer.FirstName= firstName;
          customer.LastName= lastName;
          customer.EmailAddress= email;
          customer.TelephoneNumber = phoneNumber;


           customers.Add(customer);

           return customer;

        }


        //Read Method
        public static Customer GetById(int id)
        {
            return customers.FirstOrDefault(c => c.id == id);


        }

        public static ObservableCollection<Customer> GetAll()
        {
            return customers;
        }
    

        //Delete Method
        public static void Delete(int id)
        {
            var customer = GetById(id);
            customers.Remove(customer);
        }
        //Save Data
        public static void Save()
        {
            string json = JsonConvert.SerializeObject(customers);
            File.WriteAllText("customers.json", json);
        }

        //Load Data
        public static void Load()
        {
            string json = File.ReadAllText("customers.json");

            customers = JsonConvert.DeserializeObject<ObservableCollection<Customer>>(json);
        }

    }
}
