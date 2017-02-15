using System;
using System.Collections.Generic;
using System.Text;
using ConfigItems.Models;

namespace ConfigItems
{
    interface ICSService
    {
        
        ConfigItem GetItem(string Name);

        List<ConfigItem> GetItem();

        List<ConfigItem> GetItemByCategory(string Category);

        List<ConfigItem> GetItemByOwner(string Owner);

        List<ConfigItem> GetItemByUser(string User);
    }
}
