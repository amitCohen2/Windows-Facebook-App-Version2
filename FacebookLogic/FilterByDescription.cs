using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class FilterByDescription<T> : IFilterStrategy<T>
    {
        private PropertyInfo m_DescriptionProperty;
        public string FilterString { get; set; }

        public FilterByDescription()
        {
            m_DescriptionProperty = typeof(T).GetProperty("Description");
        }

        public bool Filter(T i_Item)
        {
            bool result = false;
            if (i_Item != null && m_DescriptionProperty != null)
            {
                string currentName = m_DescriptionProperty.GetValue(i_Item) is string itemName ?
                    itemName : $"No Name for {typeof(T)}";
                result = currentName != null && currentName.IndexOf(FilterString, StringComparison.OrdinalIgnoreCase) != -1;
            }

            return result;
        }
    }
}
