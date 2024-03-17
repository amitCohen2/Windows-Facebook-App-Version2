using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FormCollectionFactory
    {
        public static Form CreateFormCollection(User i_LoggedInUser, eFormCollectionType i_FormType) 
        {
            Form createdForm = null;

            switch (i_FormType)
            {
                case eFormCollectionType.AlbumsForm:
                    createdForm = new FormObjectCollection<Album>(i_LoggedInUser.Albums);
                    break;
                case eFormCollectionType.FriendsForm:
                    createdForm = new FormObjectCollection<User>(i_LoggedInUser.Friends);
                    break;
                case eFormCollectionType.GroupsForm:
                    createdForm = new FormObjectCollection<Group>(i_LoggedInUser.Groups);
                    break;
                case eFormCollectionType.LikedPagesForm:
                    createdForm = new FormObjectCollection<Page>(i_LoggedInUser.LikedPages);
                    break;
                case eFormCollectionType.EventsForm:
                    createdForm = new FormObjectCollection<Event>(i_LoggedInUser.Events);
                    break;
                default:
                    throw new Exception();
            }

            return createdForm;
        }
    }
}
