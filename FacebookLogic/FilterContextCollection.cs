using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FilterContextCollection<T> : IEnumerable<T>
    {
        private readonly FacebookObjectCollection<T> r_Collection;

        public IFilterStrategy<T> FilterStrategy { get; set; }

        public FilterContextCollection(FacebookObjectCollection<T> i_Collection)
        {
            r_Collection = i_Collection;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in r_Collection)
            {
                if (FilterStrategy.Filter(item))
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
