using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private static readonly string rs_LikesLabelString = "Likes: {0}";
        private readonly string[] rs_CoverPhotoes = new string[2] { "COVER PHOTOS", "תמונות נושא" };
        private bool m_RememberUser;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private readonly FacebookLogicFacade r_FacebookLogicFacade;

        public bool IsLoggoutPressed { get; set; }

        public FormMain(LoginResult i_LoginResult, bool i_RememberUser)
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_FacebookLogicFacade = new FacebookLogicFacade();
            m_LoginResult = i_LoginResult;
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            m_RememberUser = i_RememberUser;
        }

        public void FetchUserInfo()
        {
            roundPictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            new Thread(() => fetchAbout()).Start();
            new Thread(() =>
            {
                fetchCoverPhoto();
                fetchAlbums();
            }).Start();
            new Thread(() => fetchPages()).Start();
            new Thread(() => fetchEvents()).Start();
            new Thread(() => fetchFriendsList()).Start();
            new Thread(() => fetchPosts()).Start();
            new Thread(() => fetchGroups()).Start();
        }

        private bool isCoverAlbum(Album i_album)
        {
            return i_album.Name.ToUpper().Equals(rs_CoverPhotoes[1]) ||
                i_album.Name.Equals(rs_CoverPhotoes[0]);
        }

        private void fetchAbout()
        {
            foreach (StringBuilder info in r_FacebookLogicFacade.GetAboutDetails(m_LoggedInUser))
            {
                listBoxAbout.Invoke(new Action(() => listBoxAbout.Items.Add(info.ToString())));
            }
        }

        private void fetchCoverPhoto()
        {
            Album coverAlbum = m_LoggedInUser.Albums.Find(isCoverAlbum);

            if (coverAlbum != null)
            {
                pictureBoxCover.Invoke(new Action(() => pictureBoxCover.LoadAsync(coverAlbum.PictureAlbumURL)));
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.CreatedTime + ": " + post.Message)));
                }
            }
        }

        private void fetchFriendsList()
        {
            int numOfFriendsToShow = Math.Min(2, m_LoggedInUser.Friends.Count);

            for (int i = 0; i < numOfFriendsToShow; i++)
            {
                string friendUserName = m_LoggedInUser.Friends[i]?.UserName;

                if (friendUserName != null)
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friendUserName)));
                }
            }
        }

        private void fetchPages()
        {
            Random rand = new Random();
            int numOfPagesToShow = Math.Min(10, m_LoggedInUser.LikedPages.Count);

            for (int i = 0; i < numOfPagesToShow; i++)
            {
                listBoxPages.Invoke(new Action(() => listBoxPages.Items.Add(m_LoggedInUser.LikedPages[rand.Next(0, m_LoggedInUser.LikedPages.Count)].Name)));
            }
        }

        private void fetchEvents()
        {
            if (m_LoggedInUser.Events.Count == 0)
            {
                listBoxEvents.Invoke(new Action(() => {
                    listBoxEvents.Items.Add("You don't have any upcoming events");
                    buttonShowMyEvents.Enabled = false;
                    buttonShowMyEvents.ForeColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                }));
            }

            foreach (Event evnt in m_LoggedInUser.Events)
            {
                if (evnt.Name != null)
                {
                    listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(evnt.Name + ": " + evnt.Description)));
                }
            }
        }

        private void fetchAlbums()
        {
            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name != null)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album.Name + ": " + album.Description)));
                }
            }
        }

        private void fetchGroups()
        {
            if (m_LoggedInUser.Groups.Count == 0)
            {
                listBoxGroups.Invoke(new Action(() => {
                    listBoxGroups.Items.Add("You don't belong to any group");
                    buttonShowMyGroups.Enabled = false;
                    buttonShowMyGroups.ForeColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                }));
            }

            foreach (Group group in m_LoggedInUser.Groups)
            {
                if (group.Name != null)
                {
                    listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group.Name)));
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_RememberUser = false;
            IsLoggoutPressed = true;
            Close();
        }

        public void Connect()
        {
            Text = $"{m_LoggedInUser.Name}'s Profile";
            FetchUserInfo();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserDetails.UserDetailsInstance.UserToken = m_RememberUser ? m_LoginResult.AccessToken : null;
            UserDetails.UserDetailsInstance.SaveToFile();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];

            labelCurrentPostLikes.Text = string.Format(rs_LikesLabelString, 1);
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
        }


        private void buttonShowMyFriends_Click(object sender, EventArgs e)
        {
            FormCollectionFactory.CreateFormCollection(m_LoggedInUser, eFormCollectionType.FriendsForm).ShowDialog();
        }

        private void buttonShowMyAlbums_Click(object sender, EventArgs e)
        {
            FormCollectionFactory.CreateFormCollection(m_LoggedInUser, eFormCollectionType.AlbumsForm).ShowDialog();
        }

        private void buttonShowAllPages_Click(object sender, EventArgs e)
        {
            FormCollectionFactory.CreateFormCollection(m_LoggedInUser, eFormCollectionType.LikedPagesForm).ShowDialog();
        }

        private void buttonShowAllGroups_Click(object sender, EventArgs e)
        {
            FormCollectionFactory.CreateFormCollection(m_LoggedInUser, eFormCollectionType.GroupsForm).ShowDialog();
        }

        private void buttonShowAllEvents_Click(object sender, EventArgs e)
        {
            FormCollectionFactory.CreateFormCollection(m_LoggedInUser, eFormCollectionType.EventsForm).ShowDialog();
        }


        private void buttonFindMatch_Click(object sender, EventArgs e)
        {
            new FormFindMatchSettings(m_LoggedInUser, r_FacebookLogicFacade).ShowDialog();
        }

        private void buttonFindThingsInCommon_Click(object sender, EventArgs e)
        {
            new FormFindThingsInCommon(m_LoggedInUser.Friends, m_LoggedInUser).ShowDialog();
        }
    }
}
