using CrmApp.Command;
using CrmApp.Repository;
using CrmApp.ViewModels.MenuViewModels;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrmApp.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MenuVModels:BaseVModels
    {
        private ApplicationContext _db { get; set; }

        private LeadsVModels _leadsVModels { get; set; }
        private CreateLeadsVModels _createLeadsVModels { get; set; }
        public MenuBaseVModels CurrentVModels { get; set; }

        public ICommand LeadsCommand { get; set; }


        public MenuVModels(ApplicationContext db)
        {
            _db = db;
            LeadsCommand = new RelayCommand(leadsMethod);
            #region LeadsVmodel
            _leadsVModels = new LeadsVModels(db);
            _leadsVModels.CreateEvent += _leadsVModels_CreateEvent;
            _createLeadsVModels = new CreateLeadsVModels(db);
            #endregion
            #region CreateLeadsVModel
            _createLeadsVModels = new CreateLeadsVModels(db);
            _createLeadsVModels.Cancel_SaveAction += _createLeadsVModels_Cancel_SaveAction;
            #endregion
            CurrentVModels = _leadsVModels;
        }

        private void _createLeadsVModels_Cancel_SaveAction(bool obj)
        {
            if (true)
            {
                _leadsVModels.LoadLeads();
            }
            CurrentVModels = _leadsVModels;
        }

        private void _leadsVModels_CreateEvent()
        {
            CurrentVModels=_createLeadsVModels;
        }

        private void leadsMethod(object obj)
        {
            CurrentVModels = _leadsVModels;
        }
    }
}
