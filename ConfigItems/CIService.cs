using System;
using System.Collections.Generic;
using System.Text;
using ConfigItems.Models;
using System.Linq; 

namespace ConfigItems
{
    public class CIService : ICSService
    {

        private List<ConfigItem> _dataContext { get; set; }


        public ConfigItem GetItem(string Name)
        {
            return _dataContext.Where(i => i.Name == Name).First();
        }

        public List<ConfigItem> GetItem()
        {
            return _dataContext;
        }

        public List<ConfigItem> GetItemByCategory(string Category)
        {
            return _dataContext.Where(i => i.Category == Category).ToList();
        }

        public List<ConfigItem> GetItemByOwner(string Owner)
        {
            return _dataContext.Where(i => i.Owner == Owner).ToList();
        }

        public List<ConfigItem> GetItemByUser(string User)
        {
            return _dataContext.Where(i => i.User == User).ToList();
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
                   new ConfigItem{Name="item4",Category="catB",User="Luke",Owner="Ops"}
               }
            );


        }

    }
}
