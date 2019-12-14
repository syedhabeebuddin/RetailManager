using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSDesktopManager.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string userName;
        private string password;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
            get
            {
                bool res = false;
                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    res = true;
                }

                return res;
            }
        }

        public void LogIn(string userName,string password)
        {

        }
    }
}
