using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcUsingModelValidations.Models;
namespace MvcUsingModelValidations.Repository
{
    public class UserRepository
    {
        public static List<User> list = new List<User>()
        {
            new User()
            {
                Name = "Sai",
                UName = "Saidurga",
                Country = "India",
                Pwd = "98765"
            }
        };
        public UserRepository()
        {
            //list = new List<User>();
            //list.Add();
        }
        public void Add(User item)
        {
            list.Add(item);//add user data into list
        }
        public User Validate(string uname,string pwd)
        {
            foreach(var item in list)
            {
                if(item.UName==uname && item.Pwd==pwd)
                {
                    return item;
                }
            }
            return null;

        }
    }
}
