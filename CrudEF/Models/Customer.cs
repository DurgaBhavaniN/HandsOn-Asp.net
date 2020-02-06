using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEF.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
        public Customer()
        {
            
        }
        public Customer(int id,string name,string email,int amount)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Amount = amount;
        }
    }
}
