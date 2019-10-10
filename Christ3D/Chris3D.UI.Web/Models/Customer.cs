using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chris3D.UI.Web.Models
{
    /// <summary>
    /// Customer 领域对象
    /// </summary>
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }


    /// <summary>
    /// 领域对象持久化层
    /// </summary>
    public class CustomerDao
    {
        public static Customer GetCustomer(string id)
        {
            return new Customer() { Id = "1", Name = "Christ", Email = "Christ@123.com" };
        }


        public static string SaveCustomer(Customer customer)
        {
            return "保存成功";
        }
    }
}
