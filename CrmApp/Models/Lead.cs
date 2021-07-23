using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApp.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Lead
    {
        public int Id { get; set; }
        public string LeadOwner { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phonne { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Linkedin { get; set; }
        public string LeadSoruce { get; set; }
        public double AnnualRevenue { get; set; }
        public int LeadAddressInformation_Id { get; set; }
        public int? LeadDescriptionInformation_Id { get; set; }
        public int Created_Id { get; set; }
        public int? Update_Id { get; set; }
    }
}
