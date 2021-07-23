using CrmApp.Models;
using CrmApp.Repository;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrmApp.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowVModels : BaseVModels
    {

        public BaseVModels CurrentVModels { get; set; }
        private LogInVModels _logInVModels { get; set; }
        private MenuVModels _menuVModels { get; set; }

        private ApplicationContext _db { get; set; }

        public MainWindowVModels()
        {
            _db = new ApplicationContext();
            _logInVModels = new LogInVModels(_db);
            _logInVModels.LoginEvent += _logInVModels_LoginEvent;

            _menuVModels = new MenuVModels(_db);
            CurrentVModels = _logInVModels;


        }

        private void _logInVModels_LoginEvent(bool obj)
        {
            if (obj)
            {
                CurrentVModels = _menuVModels;
            }
            _logInVModels.Account.Username = string.Empty;
            _logInVModels.Account.Password = string.Empty;
        }

    }
}
