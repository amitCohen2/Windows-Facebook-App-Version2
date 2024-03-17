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
    public class FilterByImage<T> : IFilterStrategy<T>
    {
        private PropertyInfo m_ImageProperty;

        public string FilterString 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public FilterByImage()
        {
            string imagePropertyName = typeof(T) == typeof(Album) ? "ImageAlbum" : "ImageNormal";
            m_ImageProperty = typeof(T).GetProperty(imagePropertyName);
        }

        public bool Filter(T i_Item)
        {
            return m_ImageProperty.GetValue(i_Item) != null;
        }
    }
}
