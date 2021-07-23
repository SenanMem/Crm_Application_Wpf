using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApp.Models
{
    [AddINotifyPropertyChangedInterface]
    public class DescriptionInformation
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
