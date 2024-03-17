using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class FacebookLogicFacade
    {
        private IAboutDetails m_AboutDetails;
        private IMatchMethods m_FindMatchLogic;

        public FacebookLogicFacade()
        {
            m_FindMatchLogic = new FindMatchLogic();
        }
        internal PrefferedUsersDetails PrefferedUsersDetails { get; set; }
        public List<StringBuilder> GetAboutDetails(User i_CurrentUser)
        {
            if (m_AboutDetails == null)
            {
                m_AboutDetails = new UserAboutDetailsAdapter(i_CurrentUser);
            }

            return m_AboutDetails.AboutUser();
        }

        public bool IsMatchFit(User i_User)
        {
           return m_FindMatchLogic.IsMatchFit(i_User, this);   
        }
        public void SetPrefferedUserDetails(decimal i_MinVal, decimal i_MaxVal, bool i_IsMaleChecked, bool i_IsFemaleChecked)
        {
            PrefferedUsersDetails = new PrefferedUsersDetails(i_MinVal, i_MaxVal, i_IsMaleChecked, i_IsFemaleChecked);
        }

        public string NothingToShow()
        {
            return $"No Match Friends to show";
        }
    }
}
