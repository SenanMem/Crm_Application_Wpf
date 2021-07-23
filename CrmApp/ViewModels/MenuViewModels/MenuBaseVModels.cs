using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApp.ViewModels.MenuViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MenuBaseVModels
    {
        public MenuBaseVModels CurrentVModels { get; set; }
    }
}
