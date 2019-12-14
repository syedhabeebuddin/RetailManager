using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSDesktopManager.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        LoginViewModel loginViewModel;
        public ShellViewModel(LoginViewModel loginVM)
        {
            loginViewModel = loginVM;
            ActivateItem(loginViewModel);
        }
    }
}
