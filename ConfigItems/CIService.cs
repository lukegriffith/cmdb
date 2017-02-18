using System;
using System.Collections.Generic;
using ConfigItems.Models;
using System.Linq; 

namespace ConfigItems
{
    public class CIService : ICIService
    {

        private List<ConfigItem> _dataContext { get; set; }


        public ConfigItem GetItem(String Name)
        {
            return _dataContext.Where(i => i.Name == Name).First();
        }

        public List<ConfigItem> GetItem()
        {
            return _dataContext;
        }

        public List<ConfigItem> GetItemByCategory(String Category)
        {
            return _dataContext.Where(i => i.Category == Category).ToList();
        }

        public List<ConfigItem> GetItemByOwner(String Owner)
        {
            return _dataContext.Where(i => i.Owner == Owner).ToList();
        }

        public List<ConfigItem> GetItemByUser(String User)
        {
            return _dataContext.Where(i => i.User == User).ToList();
        }


        public void AddItem(ConfigItem item)
        {
            _dataContext.Add(item);
        }

        public void DeleteItem(ConfigItem item)
        {
            throw new NotImplementedException();
        }

        public void ModifyItem(ConfigItem item)
        {
            throw new NotImplementedException();
        }


        public CIService()
        {

            _dataContext = new List<ConfigItem>();

            _dataContext.AddRange(

               new ConfigItem[]
               {
                   new ConfigItem{Name="item1",Category="catA",User="Luke",Owner="Ops"},
                   new ConfigItem{Name="item2",Category="catA",User="Luke",Owner="Ops"},
                   new ConfigItem{Name="item3",Category="catB",User="Luke",Owner="Ops"},
                   new ConfigItem{Name="item4",Category="catB",User="Luke",Owner="ServiceDesk"}
               }
            );


        }

    }
}
