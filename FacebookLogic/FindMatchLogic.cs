using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic
{
    internal class FindMatchLogic : IMatchMethods
    {
        public bool IsMatchFit(User i_User, FacebookLogicFacade i_FacebookLogicFacade)
        {
            return IsGenderFit(i_User, i_FacebookLogicFacade) && IsAgesFit(i_User, i_FacebookLogicFacade) && IsRelationshipStatusFit(i_User);
        }

        public bool IsRelationshipStatusFit(User i_User)
        {
            eRelationshipStatus currStatus = i_User.RelationshipStatus.Value;
            return !currStatus.Equals(eRelationshipStatus.InARelationship) &&
                !currStatus.Equals(eRelationshipStatus.Enagaged) &&
                !currStatus.Equals(eRelationshipStatus.Married);
        }

        public bool IsAgesFit(User i_User, FacebookLogicFacade i_FacebookLogicFacade)
        {
            int age = CalculateAge(i_User.Birthday);
            return age <= i_FacebookLogicFacade.PrefferedUsersDetails.MaxAge && age >= i_FacebookLogicFacade.PrefferedUsersDetails.MinAge;
        }

        public int CalculateAge(string i_Bitrhdat)
        {
            if (DateTime.TryParse(i_Bitrhdat, out DateTime birthdate))
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthdate.Year;

                if (birthdate > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
            else
            {
                // Handle invalid birthday format
                return -1; // or throw an exception or handle it as appropriate for your case
            }
        }

        public bool IsGenderFit(User i_User, FacebookLogicFacade i_FacebookLogicFacade)
        {
            return (i_User.Gender == User.eGender.male && i_FacebookLogicFacade.PrefferedUsersDetails.IsAttractInMale) ||
                (i_User.Gender == User.eGender.female && i_FacebookLogicFacade.PrefferedUsersDetails.IsAttractInFemale);
        }
    }
}
