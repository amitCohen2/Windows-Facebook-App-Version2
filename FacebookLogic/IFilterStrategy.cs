using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public interface IFilterStrategy<T>
    {
        string FilterString { get; set; }
        bool Filter(T i_Item);
    }
}