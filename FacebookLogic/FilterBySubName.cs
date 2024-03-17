using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FacebookLogic
{
    public class FilterBySubName<T> : IFilterStrategy<T>
    {   
        private PropertyInfo m_NameProperty;
        public string FilterString { get; set; }
        public FilterBySubName()
        {
            m_NameProperty = typeof(T).GetProperty("Name");
        }

        public bool Filter(T i_Item)
        {
            bool result = false;
            if (i_Item != null && m_NameProperty != null)
            {
                string currentName = m_NameProperty.GetValue(i_Item) is string itemName ?
                    itemName : $"No Name for {typeof(T)}";
                result = currentName != null && currentName.IndexOf(FilterString, StringComparison.OrdinalIgnoreCase) != -1;
            }

            return result;
        }
    }
}
