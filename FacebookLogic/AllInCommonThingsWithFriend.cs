using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Xml.Linq;

namespace BasicFacebookFeatures
{
    public class AllInCommonThingsWithFriend
    {
        public List<Group> CommonGroups {get; set;}
        public List<Event> CommoEvents { get; set; }
        public List<Page> CommonPages { get; set; }
        public List<User> CommonFriends { get; set; }

        public AllInCommonThingsWithFriend(User i_LoggedInUser, User i_OtherUser)
        {
            try
            {
                new Thread(() => fetchDetailsInCommon<Group>(i_LoggedInUser.Groups, i_OtherUser.Groups, CommonGroups));
                new Thread(() => fetchDetailsInCommon<Event>(i_LoggedInUser.Events, i_OtherUser.Events, CommoEvents));
                new Thread(() => fetchDetailsInCommon<Page>(i_LoggedInUser.LikedPages, i_OtherUser.LikedPages, CommonPages));
                new Thread(() => fetchDetailsInCommon<User>(i_LoggedInUser.Friends, i_OtherUser.Friends, CommonFriends));
            }
            catch (Exception ex) 
            {
                throw ex; // cannot find really those parameters from my friends 
            }

        }

        private void fetchDetailsInCommon<T>(
            FacebookObjectCollection<T> i_LoggedInUserCollection, 
            FacebookObjectCollection<T> i_OtherUserCollection, 
            List<T> i_CommonList)
        {
            try
            {
                PropertyInfo nameProperty = typeof(T).GetProperty("Name");

                foreach (T item in i_LoggedInUserCollection)
                {
                    if (item != null && i_OtherUserCollection.Contains(item))
                    {
                        string name = nameProperty.GetValue(item) as string ?? NoNameForItem<T>();
                        i_CommonList.Add(item);
                    }
                }
            } 
            catch (Exception ex) 
            {
                throw new Exception("Error while fetching details in common.", ex);
            }

        }

        public string NoNameForItem<T>()
        {
            return $"No {typeof(T).Name}s to show";
        }
    }
}