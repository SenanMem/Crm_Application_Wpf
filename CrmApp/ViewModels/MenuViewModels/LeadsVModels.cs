using CrmApp.Command;
using CrmApp.Models;
using CrmApp.Repository;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrmApp.ViewModels.MenuViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class LeadsVModels:MenuBaseVModels
    {
        private ApplicationContext _db { get; set; }

        public List<Lead> Leads { get; set; }
        public List<Account> Accounts { get; set; }

        public ICommand CreateCommand { get; set; }

        public event Action CreateEvent;


        public LeadsVModels(ApplicationContext db)
        {
            _db = db;
            CreateCommand = new RelayCommand(CreateMethod);
        }

        private void CreateMethod(object obj)
        {
            CreateEvent?.Invoke();
        }
        public void LoadLeads()
        {
            Accounts = _db.Accounts.ToList();
            Leads = _db.Lead_Table.ToList();
        } 
    }
}
