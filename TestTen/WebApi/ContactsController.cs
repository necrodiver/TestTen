using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi
{
    public class ContractsController : ApiController
    {
        static List<Contact> contacts;
        static ContractsController()
        {
            contacts = new List<Contact>();
            contacts.Add(new Contact { Id = "001", Name = "张三", PhoneNo = "1234-312123141", EmailAddress = "zhangsan@gmail.com", Address = "张三省张三市张三街3号" });
            contacts.Add(new Contact { Id = "002", Name = "李四", PhoneNo = "3214-425341355", EmailAddress = "lisi@gmail.com", Address = "李四省李四市李四街4号" });
        }

        public IEnumerable<Contact>Get(string id = null)
        {
            return from contract in contacts
                   where contract.Id == id || string.IsNullOrEmpty(id)
                   select contract;
        }

        public void Post(Contact contact)
        {
            contact.Id = (contacts.Count + 1).ToString("D3");
            contacts.Add(contact);
        }

        public void Put(Contact contact)
        {
            contacts.Remove(contacts.First(c=>c.Id==contact.Id));
            contacts.Add(contact);
        }

        public void Delete(string id)
        {
            contacts.Remove(contacts.First(c=>c.Id==id));
        }
    }
}
