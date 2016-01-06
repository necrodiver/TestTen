using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Common
{
   public class ContractsController:ApiController
    {
        static List<Contact> contracts;
        static ContractsController()
        {
            contracts = new List<Contact>();
        }
    }
}
