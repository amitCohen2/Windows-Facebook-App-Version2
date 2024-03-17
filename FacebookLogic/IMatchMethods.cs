using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    internal interface IMatchMethods
    {
        bool IsMatchFit(User i_User, FacebookLogicFacade i_FacebookLogicFacade);
        bool IsGenderFit(User i_User, FacebookLogicFacade i_FacebookLogicFacade);
        int CalculateAge(string i_Bitrhdat);
        bool IsAgesFit(User i_User, FacebookLogicFacade i_FacebookLogicFacade);
        bool IsRelationshipStatusFit(User i_User);

    }
}