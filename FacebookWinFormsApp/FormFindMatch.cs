using CefSharp.DevTools.Accessibility;
using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures
{
    public partial class FormFindMatch : Form
    {
        private User m_LoggedInUser;
        private List<User> m_PrefferedFriends;
        private readonly FacebookLogicFacade r_FacebookLogicFacade;
        public FormFindMatch(User i_LoggedInUser, FacebookLogicFacade i_FacebookLogicFacade)
        {
            r_FacebookLogicFacade = i_FacebookLogicFacade;
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            initialComponent();
        }

        private void initialComponent()
        {
            PropertyInfo nameProperty = typeof(User).GetProperty("Name");
            string name = null;
            m_PrefferedFriends = new List<User>();
            foreach (User friend in m_LoggedInUser.Friends)
            {

                if (r_FacebookLogicFacade.IsMatchFit(friend))
                {
                    name = nameProperty.GetValue(friend) is string friendName ? friendName : r_FacebookLogicFacade.NothingToShow();
                    listBoxMatchFriendsNames.Items.Add(name);
                    m_PrefferedFriends.Add(friend);
                }
            }

            if (m_LoggedInUser.Friends.Count == 0 || m_PrefferedFriends.Count == 0)
            {
                listBoxMatchFriendsNames.Items.Add(r_FacebookLogicFacade.NothingToShow());
            }

        }


        private void listBoxCollectionItemsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBindingSource.DataSource = m_PrefferedFriends;
            initalMainPictureValue(listBoxMatchFriendsNames.SelectedIndex); // does not working with the data binding :(
        }

        private void initalMainPictureValue(int i_SelectedIndex)
        {
            PropertyInfo pictureProperty = typeof(User).GetProperty("PictureNormalURL");

            if (pictureProperty != null && i_SelectedIndex != -1 && listBoxMatchFriendsNames.Text != r_FacebookLogicFacade.NothingToShow())
            {
                pictureNormalURLRoundPictureBox.LoadAsync(
                    pictureProperty.GetValue(m_PrefferedFriends[i_SelectedIndex]) as string);
            }
        }


    }
}
