using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    internal class UserAboutDetailsAdapter : IAboutDetails
    {
        private readonly User r_User;

        public UserAboutDetailsAdapter(User i_User)
        {
            r_User = i_User;
        }

        public List<StringBuilder> AboutUser()
        {
            List<StringBuilder> aboutDetails = new List<StringBuilder>();

            foreach (PropertyInfo property in typeof(User).GetProperties())
            {
                if (property.PropertyType == typeof(string) && !property.Name.Contains("URL") && property.GetValue(r_User) != null)
                {
                    StringBuilder currDetails = new StringBuilder();
                    aboutDetails.Add(currDetails.Append(property.Name).Append(": ").Append(property.GetValue(r_User)));
                }
            }

            return aboutDetails;
        }
    }
}
