using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApp.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class BaseVModels
    {
        public BaseVModels CurrentVModels { get; set; }
    }
}
