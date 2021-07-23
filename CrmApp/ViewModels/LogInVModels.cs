using CrmApp.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CrmApp.Command;
using CrmApp.Repository;

namespace CrmApp.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class LogInVModels:BaseVModels
    {
        private ApplicationContext _db { get; set; }
        public int senansilinecek { get; set; }

        private List<Account> _accounts { get; set; }

        public Account Account { get; set; }
        private bool _checkUser { get; set; }

        public ICommand LoginCommand { get; set; }

        public event Action<bool> LoginEvent;

        public LogInVModels(ApplicationContext db)
        {
            _accounts = new List<Account>();
            Account = new Account();
            _db = db;
            loadUser();
            LoginCommand = new RelayCommand(loginMethod);
        }
        private void loginMethod(object obj)
        {
            _checkUser = false;
            foreach (var account in _accounts)
            {
                if(account.Password== Account.Password && account.Username == Account.Username)
                {
                    _checkUser = true;
                    break;
                }
            }
            LoginEvent?.Invoke(_checkUser);
        }

        private void loadUser()
        {
            _accounts = _db.Accounts.ToList();
        } 
    }
}
