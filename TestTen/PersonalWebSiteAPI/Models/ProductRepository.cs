using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebSiteAPI.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Persion> persions = new List<Persion>();
        private int _nextId = 1;
        public ProductRepository()
        {
            Add(new Persion { Id = 1, Name = "张三", Commodity = "衣服", Price = 632.8M });
            Add(new Persion { Id = 2, Name = "李四", Commodity = "玩具", Price = 134.5M });
            Add(new Persion { Id = 3, Name = "王五", Commodity = "耳机", Price = 800 });
        }
        public IEnumerable<Persion> GetAll()
        {
            return persions;
        }

        public Persion Get(int id)
        {
            return persions.Find(p => p.Id == id);
        }

        public Persion Add(Persion item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            persions.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            persions.RemoveAll(p => p.Id == id);
        }

        public bool Update(Persion item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = persions.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            persions.RemoveAt(index);
            persions.Add(item);
            return true;
        }
    }
}