using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyclopediaSecond
{
    class UserManager
    {
        private static UserManager shared = null;
        private User user = null;
        private UserManager()
        {

        }

        public static UserManager Shared
        {
            get
            {
                if (shared == null)
                {
                    shared = new UserManager();
                }
                return shared;
            }
        }

        public User getCurrentUser()
        {
            return this.user;
        }

        public void setUpCurrentUser(User user)
        {
            this.user = user;
        }


    }
}
