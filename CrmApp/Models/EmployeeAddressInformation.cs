using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApp.Models
{
    [AddINotifyPropertyChangedInterface]
    public class EmployeeAddressInformation:AddressInformation
    {
        public int? OtherAddress_Id { get; set; }
    }
}
