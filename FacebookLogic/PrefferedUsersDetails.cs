using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacebookLogic
{
    internal class PrefferedUsersDetails
    {
        public bool IsAttractInMale { get; set; }
        public bool IsAttractInFemale { get; set; }
        public decimal MinAge { get; set; }
        public decimal MaxAge { get; set; }


        public PrefferedUsersDetails(decimal i_MinAge, decimal i_MaxAge, bool i_Male, bool i_Female)
        {
            IsAttractInMale = i_Male;
            IsAttractInFemale = i_Female;
            MinAge = i_MinAge;
            MaxAge = i_MaxAge;    
        }
    }
}
