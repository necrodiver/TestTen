using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebSiteAPI.Models
{
    public interface IProductRepository
    {
        IEnumerable<Persion> GetAll();
        Persion Get(int id);
        Persion Add(Persion item);
        void Remove(int id);
        bool Update(Persion item);
    }
}
