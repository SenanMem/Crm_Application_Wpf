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


    public class CreateLeadsVModels : MenuBaseVModels
    {
        private ApplicationContext _db { get; set; }
        private bool _check { get; set; } = false;

        public AddressInformation AdressInformation { get;set;}
        public Lead NewLead { get;set;}
        public List<string> Ceo_List { get;set;}
        public string Ceo { get;set;}

        public ICommand CancelCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand SaveAndNewCommand { get; set; }

        public event Action<bool> Cancel_SaveAction;

        public CreateLeadsVModels(ApplicationContext db)
        {
            _db = db;

            List<Account> accaounts = _db.Accounts.ToList();
            Ceo_List=new List<string>();
            Ceo_List = accaounts.Select(x => x.Username).ToList();

            AdressInformation = new AddressInformation();
            NewLead = new Lead() {LeadAddressInformation_Id = _db.AdressInformation.Count()};

            CancelCommand = new RelayCommand(Cancel);
            SaveCommand = new RelayCommand(Save);
            SaveAndNewCommand = new RelayCommand(SaveAndNew);
        }

        private void SaveAndNew(object obj)
        {
            _db.AdressInformation.Add(AdressInformation);
            _db.Lead_Table.Add(NewLead);
            _check = true;

            AdressInformation = new AddressInformation();
            NewLead = new Lead() { LeadAddressInformation_Id = _db.AdressInformation.Count()};
        }

        private void Save(object obj)
        {
            _check = true;
            _db.AdressInformation.Add(AdressInformation);
            _db.Lead_Table.Add(NewLead);
            Cancel_SaveAction?.Invoke(_check);
        }

        private void Cancel(object obj)
        {
            Cancel_SaveAction?.Invoke(_check);
        }
    }
}
